using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public float spawnInterval = 2f;
    public float minY = -4f, maxY = 4f;
    public float spawnX = -10f;
    public float moveSpeed = 3f;
    public Collider2D rightWallCollider;

    // Emails
    public string[] phishingEmails;
    public string[] normalEmails;

    void Start()
    {
        phishingEmails = new string[]
{
        "Urgent: Verify your account",
        "You�ve won a free iPhone!",
        "Reset your password now",
        "Suspicious login detected",
        "Claim your prize here"
};

        normalEmails = new string[]
        {
        "Meeting rescheduled to 3 PM",
        "Your Amazon receipt is ready",
        "Invoice #231 for review",
        "Reminder: Submit your report",
        "Lunch at 12?"
        };

        InvokeRepeating("SpawnFish", 1f, spawnInterval);
    }

    void SpawnFish()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnX, randomY, 0);

        GameObject newFish = Instantiate(fishPrefab, spawnPos, Quaternion.identity);

        // Assign tag manually if prefab is untagged
        newFish.tag = "Fish";

        // Set velocity
        Rigidbody2D rb = newFish.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.right * moveSpeed;
        }

        // Assign random email
        FishEmail fishEmail = newFish.GetComponent<FishEmail>();
        if (fishEmail != null)
        {
            fishEmail.AssignRandomEmail(phishingEmails, normalEmails);
        }

        Destroy(newFish, 10f); // remove after some time
    }

}