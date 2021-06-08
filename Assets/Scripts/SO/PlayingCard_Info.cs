using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Default", menuName = "ScriptableObjects/Cards/PlayingCard", order = 1)]
public class PlayingCard_Info : Card_Info
{
    public EnumValue suit;
    public int value;
}
    