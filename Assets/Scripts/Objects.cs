using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour {
	public GameObject GarbageCar;
	public GameObject Ambulance;
	public GameObject Bus;

	[HideInInspector]
	public Vector2 GarbageCarPos;
	[HideInInspector]
	public Vector2 AmbulancePos;
	[HideInInspector]
	public Vector2 BusPos;

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
	}
}
