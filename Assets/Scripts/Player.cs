using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerIndex;
    public int health = 8000;
    public Deck deck;
    public Hand hand;

    public void InitializePlayer(int staringHandSize) {
        for (int i = 0; i < staringHandSize; i++) {
            DrawCard();
        }
    }
    
    // M�todo para robar una carta
    public void DrawCard() {
        Card drawnCard = deck.DrawCard();

        if(drawnCard == null) {
            // Puedes manejar el caso en que el mazo est� vac�o
            Debug.Log("Jugador " + (playerIndex + 1) + " no puede robar m�s cartas, el mazo est� vac�o.");
        } else {
            hand.AddCardToHand(drawnCard);
            Debug.Log("Jugador " + (playerIndex + 1) + " roba una carta: "+ drawnCard.name);
        }
    }
}
