using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CardClass : MonoBehaviour
{
    public abstract string Color { get; }
    public abstract int Spaces { get; }
    public abstract void SetValue(string value);
    public abstract void SetValue(int value);
}
//Decorator pattern
public class RegularCard : CardClass
{
    // variables
    public string color;
    public int numSquares;

    // constructor
    public RegularCard(string c, int s){
        this.color = c;
        this.numSquares = s;
    }

    // getters & setters
    public override string Color {
        get { return color; }
    }
    public override void SetValue(string value) {
        color = value;
    }
    public override int Spaces {
        get { return this.numSquares; }
    }
    public override void SetValue(int value) {
       this.numSquares = value;
    }
}

public class SpecialCard : CardClass
{
   // variables
    public string color;
    public int numSquares;

    // constructor
    public SpecialCard(string c, int s){
        this.color = c;
        this.numSquares = s;
    }

    // getters & setters
    public override string Color {
        get { return this.color; }
    }
    public override void SetValue(string value) {
        this.color = value;
    }
    public override int Spaces {
        get { return this.numSquares; }
    }
    public override void SetValue(int value) {
       this.numSquares = value;
    }
}
