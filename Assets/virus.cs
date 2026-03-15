using UnityEngine;

public class TargetObject : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
           
            ScoreManager.AddPoint();

            
            Destroy(gameObject);
        }
    }
}