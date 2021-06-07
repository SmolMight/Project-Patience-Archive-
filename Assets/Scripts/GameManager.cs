using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnumValue[] suits = new EnumValue[4];
    [SerializeField] private PlayingCard cardPrefab;
    [SerializeField] private PlayingCard_SkinPack skinPack;

    [SerializeField] private Transform Deck;

    void Start()
    {
        for (int x = 0; x < suits.Length; x++)
        {
            for (int y = 0; y < 13; y++)
            {
              
            }
        }
    }

    void Update()
    {
        
    }

    private void CreateCard(EnumValue suit, int value)
    {
        PlayingCard pCard = new PlayingCard();

    }
}
