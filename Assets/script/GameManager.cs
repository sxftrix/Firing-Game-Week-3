using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float roundTime = 10f;
    public GameObject panel;
    public TextMeshProUGUI scoreText; // Renamed from 'Text' to avoid conflict with classes

    private float timer;
    private bool endgame;

    void Start()
    {
        timer = roundTime;
        panel.SetActive(false);
        Time.timeScale = 1f;    
    }

    void Update()
    {
        if(endgame) 
            return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        endgame = true;
        panel.SetActive(true);

        // Fixed capitalization on timeScale
        Time.timeScale = 0f; 

        // Accessing the instance we created in the Scoring script
        scoreText.text = 
            "Score: " + Mathf.RoundToInt(Scoring.Instance.currentScore) + "\n" +
            "High Score: " + Mathf.RoundToInt(Scoring.highscore);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}