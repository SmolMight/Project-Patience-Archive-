using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingCard : Card
{
    [SerializeField]
    private EnumValue Suit;
    private Sprite cardSprite;
    public float value;
}
