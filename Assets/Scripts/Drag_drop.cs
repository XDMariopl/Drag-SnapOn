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
       
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    void Start () {
		canvasGroup=GetComponent<CanvasGroup>();
        dragObjectRectTransform=GetComponent<RectTransform>();
	}
	

}
