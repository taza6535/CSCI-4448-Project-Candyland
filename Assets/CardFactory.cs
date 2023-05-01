using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    CardClass newCard=null;
    public static CardFactory instance; //Singleton
    public static CardFactory Instance { get; private set; } //Singlton

    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        //Singleton pattern
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
    public CardClass createCard(string type, string color, int numSquares){
        if (type == "regular"){
            newCard = gameObject.AddComponent<RegularCard>();
            newCard.SetValue(color);
            newCard.SetValue(numSquares);
            return newCard;
        }
        else if (type == "special"){
            newCard = gameObject.AddComponent<SpecialCard>();
            newCard.SetValue(color);
            newCard.SetValue(numSquares);
            return newCard;
        }
        else {
            return null;
        }
    }
}
