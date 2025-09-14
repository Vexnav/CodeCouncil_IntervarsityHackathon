using UnityEngine;
using TMPro;

public class EmailUI : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text emailTextUI;
    private bool currentIsPhishing;

    public void ShowEmail(string email, bool isPhishing)
    {
        panel.SetActive(true);
        emailTextUI.text = email;
        currentIsPhishing = isPhishing;
        Time.timeScale = 0f; // pause game physics
    }

    public void OnPhishingPressed()
    {
        CheckAnswer(true);
    }

    public void OnSafePressed()
    {
        CheckAnswer(false);
    }

    void CheckAnswer(bool playerChoice)
    {
        if (playerChoice == currentIsPhishing)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
        }

        panel.SetActive(false);
        Time.timeScale = 1f; // resume game
    }
}