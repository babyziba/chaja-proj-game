using UnityEngine;

public class Resourcelist
{
    public int wood;
    public int stone;
    public int gold;
}
public class ResourceData : MonoBehaviour
{
    public Resourcelist resourcelist = new Resourcelist();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resourcelist.wood = 0;
        resourcelist.stone = 0;
        resourcelist.gold = 0;
    }

    public int GetWood()
    {
        return resourcelist.wood;
    }
    public void SetWood(int amountofwood)
    {
        resourcelist.wood += amountofwood;
    }

    public int GetStone()
    {
        return resourcelist.stone;
    }
    public void SetStone(int amountofstone)
    {
        resourcelist.stone += amountofstone;
    }

    public int GetGold()
    {
        return resourcelist.gold;
    }
    public void SetGold(int amountofgold)
    {
        resourcelist.wood += amountofgold;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
