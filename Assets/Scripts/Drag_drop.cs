using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Drag_drop : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler {

    public Objects objektuSkripts;
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
        if(objektuSkripts.correctPos==false) 
        {
            canvasGroup.blocksRaycasts=true;
        }
        else
        {
            objektuSkripts.lastDraged=null;
        }
        objektuSkripts.correctPos= false;
    }

    void Start () {
		canvasGroup=GetComponent<CanvasGroup>();
        dragObjectRectTransform=GetComponent<RectTransform>();
	}
	

}
