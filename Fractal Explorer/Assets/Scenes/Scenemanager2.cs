using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager2 : MonoBehaviour
{
    private int nextSceneToLoad;


    public void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
