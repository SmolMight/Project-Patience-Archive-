using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField]
    private List<Card> cards = new List<Card>();
    public bool IsEmpty
    {
        get { return cards.Count <= 0; }
    }


    public int GetCardsCount() { return cards.Count; }

    public void ShuffleCards()
    {
        for(int x = cards.Count-1; x > 0; x--)
        {
            int rand = Random.Range(x, 0);
        }
    }

    public Card DrawCard() 
    { 
        if (cards.Count > 0)
        {
            var card = cards[cards.Count - 1];
            cards.Remove(card);
            return card;
        }
        return null;
    }
    public List<Card> DrawCards(int amount)
    {
        if (cards.Count <= 0)
            return null;

        List<Card> drawnCards = new List<Card>();
        for(int x = 0; x < amount; x++)
        {
            if (cards.Count > 0)
            {
                var card = cards[cards.Count - 1];
                drawnCards.Add(card);
                cards.Remove(card);
            }
        }
        return drawnCards;
    }
}
