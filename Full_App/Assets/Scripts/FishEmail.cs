using UnityEngine;

public class FishEmail : MonoBehaviour
{
    public TextMesh emailText;
    public bool isPhishing { get; private set; }


    public void AssignRandomEmail(string[] phishingEmails, string[] normalEmails)
    {
        isPhishing = Random.value < 0.5f;
        string chosenEmail = isPhishing
            ? phishingEmails[Random.Range(0, phishingEmails.Length)]
            : normalEmails[Random.Range(0, normalEmails.Length)];

        if (emailText != null)
        {
            emailText.text = chosenEmail;
        }
    }
}
