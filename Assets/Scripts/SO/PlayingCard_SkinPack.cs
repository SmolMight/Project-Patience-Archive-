using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Default", menuName = "ScriptableObjects/DeckSkins/Default", order = 1)]
public class PlayingCard_SkinPack : ScriptableObject
{
    public int skinCode;
    public List<Sprite> Hearts;
    public List<Sprite> Diamonds;
    public List<Sprite> Clubs;
    public List<Sprite> Spades;
    public List<Sprite> CardBacks;
}
