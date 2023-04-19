using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private Sprite[] cardTypes;
    private SpriteRenderer rend;
    private int playerTurn = 1;
    private bool coroutineAllowed = true;

    private void Start(){
        rend = GetComponent<SpriteRenderer>();
        cardTypes = Resources.LoadAll<Sprite>("CardOptions/");
        rend.sprite = cardTypes[0];
    }

    private void OnMouseDown(){
        if (!GameControl.gameOver && coroutineAllowed){
            StartCoroutine("DrawCard");
        }
    }

    private IEnumerator DrawCard(){
        coroutineAllowed = false;
        // draw random card
        int randCard = 0;
        randCard = Random.Range(0,19);
        rend.sprite = cardTypes[randCard];
        GameControl.cardPicked = randCard;
        // play turn
        if (playerTurn == 1){
            GameControl.MovePlayer(1);
        } else if (playerTurn == 2){
            GameControl.MovePlayer(2);
        }else if (playerTurn == 3){
            GameControl.MovePlayer(3);
        } else if (playerTurn == 4){
            GameControl.MovePlayer(4);
        } else {
            GameControl.MovePlayer(1);
        }
        // switch turn
        if (playerTurn == 4){
            playerTurn = 1;
        } else {
            playerTurn += 1;
        }
        coroutineAllowed = true;
        yield break;
    }

}
