using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardReader : MonoBehaviour, ICardReadable
{
    [SerializeField] PlayerState state;
    [SerializeField] PlayerGridder gridder;

    private void Start()
    {
        if (state == null) state = GetComponent<PlayerState>();
        if (gridder == null) gridder = GetComponent<PlayerGridder>();
    }


    public void ReadCard(Card card)
    {
        if (card.coordinates.Length == 0)
        {
            Debug.Log("no movement");
        }
        else if (card.coordinates.Length == 1)
        {
            Debug.Log("a move");
            gridder.MoveGrid(card.coordinates[0]);
        }
        else
        {
            foreach (Coordinate move in card.coordinates)
            {
                Debug.Log("aim move");
                gridder.AimGrid(move);
            }
        }


    }

}
