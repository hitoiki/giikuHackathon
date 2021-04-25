using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCardItem : MonoBehaviour, Item
{
    [SerializeField] GridManeger grid;
    public Card[] card;
    public void GetItem(PlayerState state)
    {
        Card summonCard = card[Random.Range(0, card.Length)];
        summonCard.useTimes += 1;
    }

    public void ItemVanish()
    {
        int randomx = Random.Range(-4, 4);
        int randomy = Random.Range(-3, 5);
        bool boo = grid.GridMove(this.transform, new Vector3Int(randomx, randomy, 0));
    }
}
