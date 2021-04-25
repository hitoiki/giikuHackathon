using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemManeger : MonoBehaviour
{
    [SerializeField] PlayerState state = null;
    public void DealItem(Item item)
    {

        item.GetItem(state);
        item.ItemVanish();
    }
}
