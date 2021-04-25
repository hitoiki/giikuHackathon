using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCount : MonoBehaviour
{
    public Card card;
    public Text text;
    void Update()
    {
        text.text = card.useTimes.ToString();

    }
}
