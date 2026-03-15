using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   
    public static int score = 0;

    public static void AddPoint()
    {
        score += 1;
        Debug.Log("Current Score: " + score); 
    }
}