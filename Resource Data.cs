using UnityEngine;

public class Resources
{
    public int Wood;
    public int Stone;
    private int gold;
}
public class ResourceData : MonoBehaviour
{
    public Resources resources = new Resources();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resources.wood = 0;
        resources.stone = 0;
        resources.gold = 0;
    }

    public void GetWood()
    {
        return wood;
    }
    public void SetWood(int amountofwood)
    {
        resources.wood += amountofwood;
    }

    public void GetStone()
    {
        return stone;
    }
    public void SetStone(int amountofstone)
    {
        resources.stone += amountofstone;
    }

    public void GetGold()
    {
        return gold;
    }
    public void SetGold(int amountofgold)
    {
        resources.wood += amountofgold;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
