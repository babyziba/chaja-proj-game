using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;



public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{


    public player player;
    Renderer environmentObj;
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer down: " + gameObject.name);

        if (player.A_ActionSlots == 6)
        {
            Debug.Log("INV FULL BRO");
            return;
        }
        
        player.A_ActionSlots += 1;
        player.invState = 0;


        if (player.A_ActionSlots == 3)
        {
            player.invState = 2;
            environmentObj.material.color = Color.orange;

        }
        if (player.A_ActionSlots == 6)
        {
            player.invState = 3;
            environmentObj.material.color = Color.red;

        }


        Debug.Log("A_ActionSlots Value = " + player.A_ActionSlots);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Pointer up: " + gameObject.name);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Pointer click: " + gameObject.name);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer enter: " + gameObject.name);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer exit: " + gameObject.name);
    }
    void Start()
    {
        environmentObj = GetComponent<MeshRenderer>();
        environmentObj.material.color = Color.green;
    }
    
}
