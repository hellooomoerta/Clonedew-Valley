using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : SingletonMonobehaviour<InventoryManager>
{
    [SerializeField] private SOItemList itemList = null;

    private Dictionary<int, ItemDetails> itemDetailsDictionary;

    protected override void Awake()
    {
        base.Awake();
        CreateItemDetailsDictionary();
    }

    //Populates the itemDetailsDictionary from the scriptable object item list
    private void CreateItemDetailsDictionary()
    {
        itemDetailsDictionary = new Dictionary<int, ItemDetails>();

        foreach (ItemDetails itemDetails in itemList.itemDetails)
        {
            itemDetailsDictionary.Add(itemDetails.itemNumber, itemDetails);
        }
    }

    public ItemDetails GetItemDetails(int itemNumber)
    {
        ItemDetails itemDetails;

        if (itemDetailsDictionary.TryGetValue(itemNumber, out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }
}
