using UnityEngine;

public class ItemDetails
{
    public int itemNumber;
    public ItemType itemType; //Enum of item type
    public string itemDescription; //Short description
    public string itemLongDescription; //Long description in inventory
    public Sprite itemSprite;
    public short itemUseGridRadius; //How many grid spaces away from character the item can be used (axe for example)
    public bool isStartingItem;
    public bool canBePickedUp;
    public bool canBeDropped;
    public bool canBeEaten;
    public bool canBeCarried; //Wheather an item is carried over the characters head if selected on the inventory bar
}
