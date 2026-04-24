using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public int totalCoins = 5;

    public TextMeshProUGUI scoreText;
    public GameObject winText;

    void Update()
    {
        scoreText.text = "Score: " + score;

        if(score >= totalCoins)
        {
            winText.SetActive(true);
        }
    }
}