using UnityEngine;

public class ContinuousMusic : MonoBehaviour
{
    
    private static ContinuousMusic instance;

    void Awake()
    {
        
        if (instance != null && instance != this)
        {
            
            Destroy(gameObject);
            return;
        }

        
        instance = this;

        
        DontDestroyOnLoad(gameObject);
    }
}