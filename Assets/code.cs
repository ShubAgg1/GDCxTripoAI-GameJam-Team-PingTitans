using UnityEngine;

public class code : MonoBehaviour
{
    public GameObject cubePrefab;

    // Time settings 
    public float spawnDelay = 1.5f;
    public float minSpawnDelay = 0.2f;
    public float decreaseRate = 0.1f;   
    
    public float gameDuration = 60f;   
    private float totalTimePassed = 0f; 

   
    private float timer = 0f;

    void Update()
    {
        
        totalTimePassed += Time.deltaTime;

        
        if (totalTimePassed < gameDuration)
        {
            
            timer += Time.deltaTime;

            
            if (timer >= spawnDelay)
            {
                
                Vector3 randomspawnposition = new Vector3(Random.Range(-20, 21), 6f, Random.Range(-20, 21));
                Instantiate(cubePrefab, randomspawnposition, Quaternion.identity);

                
                timer = 0f;

                
                if (spawnDelay > minSpawnDelay)
                {
                    spawnDelay -= decreaseRate;
                }
            }
        }
        
    }
}