using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Factory pattern for creating cards
public class CardFactory : MonoBehaviour
{
    CardClass newCard=null;
    //Singleton pattern based off of: https://gamedevbeginner.com/singletons-in-unity-the-right-way/ 
    public static CardFactory instance; //Singleton
    public static CardFactory Instance { get; private set; } //Singleton pattern

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
