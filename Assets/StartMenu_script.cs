using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuController : MonoBehaviour
{
    
    public void RestartGame()
    {
        
        SceneManager.LoadScene("StartScene");
        ScoreManager.score = 0;

        
    }
}
