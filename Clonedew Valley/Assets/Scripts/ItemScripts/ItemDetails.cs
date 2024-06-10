using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    public int itemNumber;
    public ItemType itemType; //Enum of item type
    public string itemDescription; //Short description (name of item)
    //public string itemLongDescription; //Longer description of what the item is
    public Sprite itemSprite;
    public short itemUseGridRadius; //How many grid spaces away from character the item can be used (axe for example)
    public bool isStartingItem;
    public bool canBePickedUp;
    public bool canBeDropped;
    public bool canBeEaten;
    public bool canBeCarried; //Wheather an item is carried over the characters head if selected on the inventory bar
}
