using UnityEngine;
using UnityEngine.EventSystems;


public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public player player;
        public void OnPointerDown(PointerEventData eventData){
        Debug.Log("Pointer down: " + gameObject.name);
        player.A_ActionSlots += 1;
        Debug.Log("A_ActionSlots Value = " + player.A_ActionSlots);
    }
    public void OnPointerUp(PointerEventData eventData){
        Debug.Log("Pointer up: " + gameObject.name);
    }
    public void OnPointerClick(PointerEventData eventData){
        Debug.Log("Pointer click: " + gameObject.name);
    }
    public void OnPointerEnter(PointerEventData eventData){
        Debug.Log("Pointer enter: " + gameObject.name);
    }
    public void OnPointerExit(PointerEventData eventData){
        Debug.Log("Pointer exit: " + gameObject.name);
    }
}
