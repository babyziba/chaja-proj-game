using UnityEngine;
using UnityEngine.EventSystems;

public class Environment : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int OriginalState;
    [SerializeField] private int ModifiedState; // Current Max Value
    [SerializeField] private int Phase;
    Renderer environmentObj;


    void Start()
    {
        // Initial values for testing purposes
        OriginalState = ModifiedState = 5;
        Phase = 3;
        // Passing the 3D object to manipulate its properties
        environmentObj = GetComponent<MeshRenderer>();
        // Setting a base color
        environmentObj.material.color = Color.green;
    }

    // Getters and Setters
    public int getOriginalState()
    {
        return this.OriginalState;
    }

    public int getModifiedState()
    {
        return this.ModifiedState;
    }

    public int getPhase()
    {
        return this.Phase;
    }

    public void setOriginalState(int x)
    {
        this.OriginalState = x;
    }

    public void setModifiedState(int x)
    {
        this.ModifiedState = x;
    }

    public void setPhase(int x)
    {
        this.Phase = x;
    }

    // Handle Click Interactions

    public void OnPointerClick(PointerEventData eventData)
    {
        int currentModifiedState = this.getModifiedState();
        int currentPhase = this.getPhase();
        currentModifiedState -= 1;
        Debug.Log($"Current phase value is {currentPhase}");
        Debug.Log($"Current modified state value value is {currentModifiedState}");

        if (currentModifiedState == 3)
        {
            environmentObj.material.color = Color.orange;
            this.setPhase(currentPhase - 1);
        }
        if (currentModifiedState == 1)
        {
            environmentObj.material.color = Color.red;
            this.setPhase(currentPhase - 1);
        }
        this.setModifiedState(currentModifiedState);
    }
}
