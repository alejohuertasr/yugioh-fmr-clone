using UnityEngine;

[System.Serializable]
public class Card
{
    public string name;
    public int attack;
    public int defense;

    public Card (string name, int attack, int defense) {
        this.name = name;
        this.attack = attack; 
        this.defense = defense;
    }
}
