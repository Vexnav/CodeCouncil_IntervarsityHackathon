/*using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public FishSpawner spawner;
    public SharkController shark;
    public EmailUI emailUI;

    void Awake()
    {
        Instance = this;
    }

    public void FishEaten(FishEmail fishEmail)
    {
        // Stop spawning new fish
        spawner.enabled = false;

        // Stop all fish movement
        Rigidbody2D[] allFish = FindObjectsOfType<Rigidbody2D>();
        foreach (var fish in allFish)
        {
            fish.linearVelocity = Vector2.zero;
        }

        // Disable shark movement
        shark.DisableMovement();

        // Show email prompt
        emailUI.ShowEmail(fishEmail.emailText, fishEmail.isPhishing);
    }

    public void ResumeGame()
    {
        spawner.enabled = true;
        shark.EnableMovement();
    }
}*/