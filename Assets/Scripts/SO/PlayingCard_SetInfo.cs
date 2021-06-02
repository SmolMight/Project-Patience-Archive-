using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Decks/PlayingCards", order = 1)]
public class PlayingCard_SetInfo : ScriptableObject
{
    public struct PlayingCardInfo
    {
        public EnumValue Suit;
        public float value;
    }
    public List<PlayingCardInfo> PlayingCards;
}
