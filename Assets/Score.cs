using UnityEngine;
using TMPro; 

public class FinalScoreDisplay : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;

    void Start()
    {
       
        scoreText.text = "Final Score: " + ScoreManager.score.ToString();
    }
}
