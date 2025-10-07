using UnityEngine;
using TMPro;

public class ui_manager : MonoBehaviour
{
    public player playerScript;
    public TextMeshProUGUI actionSlotA;
    public TextMeshProUGUI actionSlotB;
    public TextMeshProUGUI gatherSlotA;
    public TextMeshProUGUI gatherSlotB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        actionSlotA.text = "Action Slot (A): " + playerScript.A_ActionSlots;
        actionSlotB.text = "Action Slot (B): " + playerScript.B_ActionSlots;
        gatherSlotA.text = "Gather Slot (A): " + playerScript.A_GatherSlots;
        gatherSlotB.text = "Gather Slot (B): " + playerScript.B_GatherSlots;
    }

    // Update is called once per frame
    void Update()
    {
        actionSlotA.text = "Action Slot (A): " + playerScript.A_ActionSlots;
        actionSlotB.text = "Action Slot (B): " + playerScript.B_ActionSlots;
        gatherSlotA.text = "Gather Slot (A): " + playerScript.A_GatherSlots;
        gatherSlotB.text = "Gather Slot (B): " + playerScript.B_GatherSlots;
    }
}
