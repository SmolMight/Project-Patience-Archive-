using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Default", menuName = "ScriptableObjects/Decks/Deck", order = 1)]
public class Deck_Info : ScriptableObject 
{
    public List<Card_Info> Cards = new List<Card_Info>();
}
