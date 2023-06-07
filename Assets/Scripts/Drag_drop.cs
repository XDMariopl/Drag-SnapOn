using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag_drop : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler {

    public Objects objektuSkripts;
    public TimeCounting TimeScript;
    private CanvasGroup canvasGroup;
    private RectTransform dragObjectRectTransform;
    public void OnBeginDrag(PointerEventData eventData)
    {
        objektuSkripts.lastDraged = null;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragObjectRectTransform.anchoredPosition += eventData.delta / objektuSkripts.canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
            objektuSkripts.lastDraged = eventData.pointerDrag;
            canvasGroup.alpha = 1f;
            if (objektuSkripts.correctPos == false)
            {
                canvasGroup.blocksRaycasts = true;
            }
            else
            {
                objektuSkripts.lastDraged = null;
                objektuSkripts.CountCorrectPos+=1;
            }
            objektuSkripts.correctPos= false;
    }

    void Start () {
		canvasGroup=GetComponent<CanvasGroup>();
        dragObjectRectTransform=GetComponent<RectTransform>();
	}

    void Update() 
    {
        if (objektuSkripts.CountCorrectPos == 3)
        {
            TimeScript.timerActive = false;
            TimeScript.EndScreen();
            objektuSkripts.CountCorrectPos += 1;
        }
    }
	

}
