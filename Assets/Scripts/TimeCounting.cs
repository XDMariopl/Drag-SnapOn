using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounting : MonoBehaviour {
    [HideInInspector]
    public Vector2 TimerPos;

    public string currentScene =SceneManager.GetActiveScene().name;
    public Objects objektuskripts;
    private float TimeStart;
    public Text txtBox;
    public bool timerActive = true;

    void Start () 
    {
        TimerPos = txtBox.GetComponent<RectTransform>().localPosition;
        txtBox.text = TimeStart.ToString("F2");
    }

    void Update () 
    {
        if (timerActive == true)
        {
            TimeStart += Time.deltaTime;
            txtBox.text = TimeStart.ToString("F2");
        }
    }

    public void EndScreen()
    {
        objektuskripts.EndScreen.SetActive(true);
        txtBox.transform.position = new Vector3 (0f, 30f, 0f);
        txtBox.text += "s";
    }

    public void Restart()
    {
        SceneManager.LoadScene(currentScene);
    }

}
