using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    public Button removeButton;

    public void RemoveItem()
    {
        Inventario.Instance.quitarObjeto(item);

        Destroy(item);
    }

    // Update is called once per frame
    public void AddItem(Item newItem)
    {
        item = newItem;
    }
}
