using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSetButton : MonoBehaviour
{
    [SerializeField] Card[] cards;
    [SerializeField] PlayerState[] players;
    [SerializeField] GameObject item;
    public void OnClick()
    {
        foreach (Card c in cards)
        {
            c.useTimes = 3;
        }
        players[0].transform.position = new Vector3(-1.3055f, 0.077f, 0);
        players[1].transform.position = new Vector3(-3.9935f, -0.819f, 0);
        players[2].transform.position = new Vector3(0.4864998f, 2.765f, 0);

        item.transform.position = new Vector3(-1.3055f, 0.973f, 0);

    }
}
