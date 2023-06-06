using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounting : MonoBehaviour {
    public float TimeStart;
    public Text txtBox;

    void Start () 
    {
        txtBox.text = TimeStart.ToString();
    }

}
