using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public string SceneToLoad;
    public void Quit()
    {
        Application.Quit();
        //Debug.Log("Quit!");
    }
    
    public void Play()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    
    // Start is called before the first frame update
}
