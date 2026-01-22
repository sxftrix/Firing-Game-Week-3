using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static Scoring Instance;
    public float currentScore = 0;
    public static float highscore = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void ProcessHit(RaycastHit hit)
    {
        float pointsEarned = hit.distance * 1f;
        currentScore += pointsEarned;

        if (currentScore > highscore)
        {
            highscore = currentScore;
        }

        Destroy(hit.transform.gameObject);
    }

    public void DisplayStats()
    {
        Debug.Log("Final Score: " + currentScore);
        Debug.Log("Highscore: " + highscore);
    }
}