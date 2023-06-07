using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour {
	public GameObject GarbageCar;
	public GameObject Ambulance;
	public GameObject Bus;
	public GameObject B2;
	public GameObject E46;
	public GameObject E61;
    public GameObject Police;
    public GameObject CementCar;
    public GameObject Firetruck;
    public GameObject Tracktor1;
    public GameObject Tracktor2;
    public GameObject Excavator;
    public int CountCorrectPos=0;
    public GameObject EndScreen;

    [HideInInspector]
	public Vector2 GarbageCarPos;
	[HideInInspector]
	public Vector2 AmbulancePos;
	[HideInInspector]
	public Vector2 BusPos;
    [HideInInspector]
    public Vector2 B2Pos;
    [HideInInspector]
    public Vector2 E46Pos;
    [HideInInspector]
    public Vector2 E61Pos;
    [HideInInspector]
    public Vector2 PolicePos;
    [HideInInspector]
    public Vector2 CementCarPos;
    [HideInInspector]
    public Vector2 FiretruckPos;
    [HideInInspector]
    public Vector2 Tracktor1Pos;
    [HideInInspector]
    public Vector2 Tracktor2Pos;
    [HideInInspector]
    public Vector2 ExcavatorPos;

    public Canvas canvas;

	public AudioSource audioSource;
	public AudioClip[] audioClips;

	[HideInInspector]
	public bool correctPos = false;
	public GameObject lastDraged = null;


	void Start () {
		GarbageCarPos = GarbageCar.GetComponent<RectTransform>().localPosition;
		AmbulancePos = Ambulance.GetComponent<RectTransform>().localPosition;
		BusPos = Bus.GetComponent<RectTransform>().localPosition;
        B2Pos = B2.GetComponent<RectTransform>().localPosition;
        E46Pos=E46.GetComponent<RectTransform>().localPosition;
        E61Pos=E61.GetComponent<RectTransform>().localPosition;
        PolicePos=Police.GetComponent<RectTransform>().localPosition;
        CementCarPos=CementCar.GetComponent<RectTransform>().localPosition;
        Tracktor1Pos=Tracktor1.GetComponent<RectTransform>().localPosition;
        Tracktor2Pos=Tracktor2.GetComponent<RectTransform>().localPosition;
        ExcavatorPos=Excavator.GetComponent<RectTransform>().localPosition;
        FiretruckPos=Firetruck.GetComponent<RectTransform>().localPosition;
	}
}
