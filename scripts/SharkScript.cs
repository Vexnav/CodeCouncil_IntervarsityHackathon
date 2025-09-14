using UnityEngine;
using UnityEngine.SceneManagement; // for reloading or changing scenes

public class SharkController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    public float minX = -8f, maxX = 8f;
    public float minY = -4f, maxY = 4f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;

        // Clamp position
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, minX, maxX);
        clampedPos.y = Mathf.Clamp(clampedPos.y, minY, maxY);

        transform.position = clampedPos;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fish"))
        {
            FishEmail fish = other.GetComponent<FishEmail>();

            if (fish != null)
            {
                if (fish.isPhishing)
                {
                    GameOver();
                }

                Destroy(other.gameObject);
            }
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}

