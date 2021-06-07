using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingCard : Card
{
    [SerializeField]
    private EnumValue Suit;
    private Sprite cardSprite;
    private float value;

    public void Init(EnumValue cSuit, Sprite cSprite, int val)
    {
        Suit = cSuit;
        cardSprite = cSprite;
        value = val;
    }
}
