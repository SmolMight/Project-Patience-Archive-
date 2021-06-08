using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingCard : Card
{
    [SerializeField]
    private EnumValue Suit;
    [SerializeField]
    private float value;

    private Sprite cardSprite;
    private Sprite cardbackSprite;

    public void Init(EnumValue cSuit, Sprite cSprite, int val)
    {
        Suit = cSuit;
        cardSprite = cSprite;
        value = val;
    }
    public void Init(EnumValue cSuit, int val)
    {
        Suit = cSuit;
        value = val;
    }
}
