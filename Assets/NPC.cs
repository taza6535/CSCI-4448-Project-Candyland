using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public string namespace Name
    {
        get;
        set;
    }
    public int PowerLevel
    {
        get;
        set;
    }
    public goodEvent goodChance
    {
        get;
        set;
    }
    public badEvent badChance
    {
        get;
        set;
    }

}

interface Event : MonoBehaviour
{
    double randomEvent(int pl);
}

public class goodEvent : Event 
{
    double randomEvent(int pl){
        return pl/100;
    }
}

public class badEvent : Event 
{
    double randomEvent(int pl){
        return pl/100;
    }
}
