using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Strategy pattern for NPC event 
//interface based off of: https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp

public class NPC : MonoBehaviour
{
    public string Name
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

public interface Event
{
    public double randomEvent(int pl);
}

public class goodEvent : MonoBehaviour, Event 
{
    public double randomEvent(int pl){
        return pl/100;
    }
}

public class badEvent : MonoBehaviour, Event 
{
    public double randomEvent(int pl){
        return pl/100;
    }
}
