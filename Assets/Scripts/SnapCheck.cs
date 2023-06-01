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
                        case "B2":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[4]);
                            break;
                        case "E46":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[11]);
                            break;
                        case "E61":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[4]);
                            break;
                        case "Police":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[6]);
                            break;
                        case "Cement":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[10]);
                            break;
                        case "Tracktor1":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[7]);
                            break;
                        case "Tracktor2":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[8]);
                            break;
                        case "Firetruck":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[11]);
                            break;
                        case "Excavator":
                            objektuskripts.audioSource.PlayOneShot(objektuskripts.audioClips[9]);
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
                    case "B2":
                        objektuskripts.B2.GetComponent<RectTransform>().localPosition = objektuskripts.B2Pos;
                        break;
                    case "E46":
                        objektuskripts.E46.GetComponent<RectTransform>().localPosition = objektuskripts.E46Pos;
                        break;
                    case "E61":
                        objektuskripts.E61.GetComponent<RectTransform>().localPosition = objektuskripts.E61Pos;
                        break;
                    case "Police":
                        objektuskripts.Police.GetComponent<RectTransform>().localPosition = objektuskripts.PolicePos;
                        break;
                    case "Cement":
                        objektuskripts.CementCar.GetComponent<RectTransform>().localPosition = objektuskripts.CementCarPos;
                        break;
                    case "Tracktor1":
                        objektuskripts.Tracktor1.GetComponent<RectTransform>().localPosition = objektuskripts.Tracktor1Pos;
                        break;
                    case "Tracktor2":
                        objektuskripts.Tracktor2.GetComponent<RectTransform>().localPosition = objektuskripts.Tracktor2Pos;
                        break;
                    case "Firetruck":
                        objektuskripts.Firetruck.GetComponent<RectTransform>().localPosition = objektuskripts.FiretruckPos;
                        break;
                    case "Excavator":
                        objektuskripts.Excavator.GetComponent<RectTransform>().localPosition = objektuskripts.ExcavatorPos;
                        break;
                }
            }
        }

    }
}
