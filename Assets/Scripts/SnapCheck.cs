using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SnapCheck : MonoBehaviour,IDropHandler {
	private float spotRotZ, dragObjectRotZ, RotRange;
	private Vector2 spotSize, dragObjectSize;
	private float xSizeRange, ySizeRange;
	public Objects objektuskripts;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag!= null)
        {
            if(eventData.pointerDrag.tag.Equals(tag))
            {
                spotRotZ= GetComponent<RectTransform>().transform.eulerAngles.z;
                dragObjectRotZ=eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                RotRange = Mathf.Abs(dragObjectRotZ - spotRotZ);

                dragObjectSize = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                spotSize=GetComponent<RectTransform>().localScale;
                xSizeRange=Mathf.Abs(dragObjectSize.x - spotSize.x);
                ySizeRange=Mathf.Abs(dragObjectSize.y - spotSize.y);
                
                if((RotRange<=5 || (RotRange<=355 && RotRange<=360))&&(xSizeRange<=0.1 && ySizeRange <= 0.1))
                {
                    objektuskripts.correctPos= true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;

                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation=GetComponent<RectTransform>().localRotation;

                    eventData.pointerDrag.GetComponent<RectTransform>().localScale=GetComponent<RectTransform>().localScale;

                    switch(eventData.pointerDrag.tag)
                    {
                        case "Garbage":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[1]);
                            break;
                        case "Ambulance":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[2]);
                            break;
                        case "Bus":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[3]);
                            break;
                    }
                }
            }
            else
            {
                objektuskripts.correctPos= false;
                objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "Garbage":
                        objektuskripts.GarbageCar.GetComponent<RectTransform>().localPosition = objektuskripts.GarbageCarPos;
                        break;
                    case "Ambulance":
                        objektuskripts.Ambulance.GetComponent<RectTransform>().localPosition=objektuskripts.AmbulancePos;
                        break;
                    case "Bus":
                        objektuskripts.Bus.GetComponent<RectTransform>().localPosition=objektuskripts.BusPos;
                        break;
                }
            }
        }

    }
}
