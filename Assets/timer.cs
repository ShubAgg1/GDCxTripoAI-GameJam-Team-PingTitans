using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneTimer : MonoBehaviour
{
    
    public string sceneToLoad = "NextSceneName";

    void Start()
    {
       
        Invoke("SwitchScene", 30f);
    }

    void SwitchScene()
    {
       
        SceneManager.LoadScene(sceneToLoad);
    }
}