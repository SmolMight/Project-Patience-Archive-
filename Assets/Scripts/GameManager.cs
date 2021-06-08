using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Deck_Info deckInfo;
    [SerializeField] private PlayingCard_SkinPack skinPack;
    [SerializeField] private PlayingCard cardPrefab;

    [SerializeField] private Transform deck;

    void Start()
    {
        foreach(PlayingCard_Info cInfo in deckInfo.Cards)
        {
            PlayingCard card = Instantiate(cardPrefab) as PlayingCard;
            card.Init(cInfo.suit, cInfo.value);
            card.transform.SetParent(deck);
        }
    }

    void Update()
    {
        
    }
}
