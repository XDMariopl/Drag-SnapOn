using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounting : MonoBehaviour {
    [HideInInspector]
    public Vector2 TimerPos;

    public Objects objektuskripts;

    private float TimeStart;
    public Text timeBox;
    public Text scoreBox;
    public bool timerActive = true;

    void Start () 
    {
        TimerPos = timeBox.GetComponent<RectTransform>().localPosition;
        timeBox.text = TimeStart.ToString("F2");
    }

    void Update () 
    {
        if (timerActive == true)
        {
            TimeStart += Time.deltaTime;
            timeBox.text = TimeStart.ToString("F2");
        }
    }

    public void EndScreen() 
    {
        objektuskripts.ExitButton.SetActive(true);
        objektuskripts.RestartButton.SetActive(true);
        objektuskripts.EndScreen.SetActive(true);
        timeBox.transform.position = new Vector3 (0f, 30f, 0f);
        timeBox.text += "s";
        if (TimeStart <= 70.0f)
        {
            scoreBox.text += "★★★";
        }else if(TimeStart<= 120.0f)
        {
            scoreBox.text += "★★_";
        }
        else
        {
            scoreBox.text += "★__";
        }
    }
}
