using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player[] players;
    public int currentPlayerIndex = 0;
    public int startingHandSize = 5;

    void Start()
    {
        StartGame();
    }

    void StartGame() {
        foreach (Player player in players) {
            player.InitializePlayer(startingHandSize);
        }

        StartTurn();
    }
    // Inicia el turno del jugador actual
    void StartTurn() {
        Debug.Log("Turno del jugador" + (currentPlayerIndex + 1));

        // Inicia la fase de robo
        players[currentPlayerIndex].DrawCard();
        // Puedes realizar otras acciones al inicio del turno aquí

        // Puedes actualizar la interfaz de usuario, mostrar mensajes, etc.
    }

    // Llamado cuando el jugador actual ha completado su turno
    public void EndTurn() {
        // Cambia al siguiente jugador
        currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;

        // Inicia el turno del siguiente jugador
        StartTurn();
    }
}
