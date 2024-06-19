using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item item;

    void pickup()
    {
        Inventario.Instance.AgregarObjeto(item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        pickup();
    }
}
