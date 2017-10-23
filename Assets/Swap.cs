using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Swap : MonoBehaviour, IDropHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        Text myLetter = GetComponentInChildren<Text>();
        Text dropLetter = eventData.pointerDrag.GetComponentInChildren<Text>();
        if (myLetter != null && dropLetter != myLetter)
        {
            string letter = myLetter.text;
            myLetter.text = dropLetter.text;
            dropLetter.text = letter;
        }
    }
}
