using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public ItemData[] items;
    public void Awake()
    {
        ItemArray();
    }

    public void ItemArray()
    {
        items = new ItemData[]
        {
        new ItemData("Axe", "This is Axe. ATK+", 7),
        new ItemData("Armor", "This is Armor. HP+", 100),
        new ItemData("Bracer", "This is Bracer. CRT+", 10),
        new ItemData("Helmet", "This is Helmet. DEF+", 7),
        new ItemData("Necklace", "This is Necklace. CRT+", 15),
        new ItemData("Shield", "This is Shield. DEF+", 8),
        new ItemData("Sword", "This is Sword. ATK+", 5),
        new ItemData("Bow", "This is Bow. ATK+", 8),
        new ItemData("Pants", "This is Pants. HP+", 50),
        };
    }
}
