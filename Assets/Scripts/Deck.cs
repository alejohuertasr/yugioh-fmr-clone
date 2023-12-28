using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cards = new List<Card>();

    // Llena el mazo con cartas
    public void InitializeDeck(List<Card> initialCards) {
        cards.Clear();
        cards.AddRange(initialCards);
        ShuffleDeck();
    }
    
    // Baraja el mazo
    public void ShuffleDeck() {
        for (int i = 0; i < cards.Count; i++) { 
            Card temporalCard = cards[i];
            int randomIndex = Random.Range(i, cards.Count);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temporalCard;
        }
    }

    // Roba una carta del mazo
    public Card DrawCard() {
        if (cards.Count > 0) {
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        } else {
            Debug.LogWarning("Intenta robar carta de mazo vacío.");
            return null;
        }
    }

}