using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Switch_Scenes : MonoBehaviour {

    public void ToStart()
    {
        SceneManager.LoadScene("start_scene", LoadSceneMode.Single);
    }

    public void ToMain()
    {
        SceneManager.LoadScene("start_scenes",LoadSceneMode.Single);
    }


}
