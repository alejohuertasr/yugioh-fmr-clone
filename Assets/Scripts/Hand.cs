using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<Card> cardsInHand = new List<Card>();

    // A�ade una carta a la mano
    public void AddCardToHand(Card card) {
        cardsInHand.Add(card);
    }
}
