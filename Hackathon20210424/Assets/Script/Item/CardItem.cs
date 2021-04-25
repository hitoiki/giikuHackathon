using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardItem : MonoBehaviour, Item
{
    public Card card;
    public void GetItem(PlayerState state)
    {
        Instantiate(card, card.CardPoint, card.transform.rotation);
    }

    public void ItemVanish()
    {
        this.gameObject.SetActive(false);
    }
}
