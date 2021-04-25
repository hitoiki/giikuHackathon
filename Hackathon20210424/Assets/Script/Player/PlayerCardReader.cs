using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardReader : MonoBehaviour, ICardReadable
{
    [SerializeField] PlayerState state;
    [SerializeField] PlayerGridMover gridMover;

    private void Start()
    {
        if (state == null) state = GetComponent<PlayerState>();
        if (gridMover == null) gridMover = GetComponent<PlayerGridMover>();
    }


    public void ReadCard(Card card)
    {
        if (card.useTimes > 0)
        {
            if (card.coordinates.Length == 0)
            {
                Debug.Log("no movement");
            }
            else if (card.coordinates.Length == 1)
            {
                Debug.Log("a move");
                bool boo = gridMover.MoveGrid(card.coordinates[0]);
                if (boo) card.useTimes -= 1;

            }
            else
            {
                foreach (Coordinate move in card.coordinates)
                {
                    Debug.Log("aim move");

                }
            }

        }


    }

}
