using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    public CardClass createCard(string type, string color, int numSqaures){
        if (type == "regular"){
            return gameObject.AddComponent<RegularCard>(color, numSqaures) as RegularCard;
        }
        else if (type == "special"){
            return gameObject.AddComponent<SpecialCard>(color, numSqaures) as SpecialCard;
        }
        else {
            return null;
        }
    }
}
