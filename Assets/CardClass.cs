using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CardClass : MonoBehaviour
{
    public abstract string Color { get; }
    public abstract int Spaces { get; }
}

public class RegularCard : CardClass
{
    // variables
    private string color;
    private int spaces;

    // constructor
    public RegularCard(string c, int s){
        color = c;
        spaces = s;
    }

    // getters & setters
    public override string Color {
        get { return color; }
    }
    public void SetValue(string value) {
        color = value;
    }
    public override int Spaces {
        get { return spaces; }
    }
    public void SetValue(int value) {
       spaces = value;
    }
}

public class SpecialCard : CardClass
{
   // variables
    private string color;
    private int spaces;

    // constructor
    public SpecialCard(string c, int s){
        color = c;
        spaces = s;
    }

    // getters & setters
    public override string Color {
        get { return color; }
    }
    public void SetValue(string value) {
        color = value;
    }
    public override int Spaces {
        get { return spaces; }
    }
    public void SetValue(int value) {
       spaces = value;
    }
}
