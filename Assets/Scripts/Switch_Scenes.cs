using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch_Scenes : MonoBehaviour {

    public string currentScene;

    void Start() 
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    public void ToStart()
    {
        SceneManager.LoadScene("start_scene", LoadSceneMode.Single);
    }

    public void ToMain()
    {
        SceneManager.LoadScene("start_scenes",LoadSceneMode.Single);
    }

    public void Restart()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
