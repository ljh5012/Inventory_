using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData 
{
    public string itemName { get; private set; }
    public string itemDescription { get; private set; }
    public int itemValue { get; private set; }    
    


    public ItemData(string itemname, string itemdescription, int itemvalue)
    {
        itemName = itemname;
        itemDescription = itemdescription;
        itemValue = itemvalue;
        
    }
}
