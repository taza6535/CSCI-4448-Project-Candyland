using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    private static GameObject player1, player2, player3, player4;
    // initialize card picked index 
    public static int cardPicked = 0;
    // initialize where players start
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;
    // initialize that game is not over 
    public static bool gameOver = false;
    // create game board array with all board spaces 
    public string[] gameBoard = new string[] {"red","purple","yellow","blue","orange","green","red","purple","gingerbread","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","candycane","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","yellow","gumdrop","blue","orange","green","licorice","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","peanut","green","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","yellow","licorice","orange","green","red","purple","yellow","lollipop","blue","orange","green","red","purple","yellow","blue","orange","green","ice cream","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","licorice","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","purple","yellow","blue","orange","green","red","rainbow"};
    public List<CardClass> cards;
    public CardFactory Cfactory;
    // Start is called before the first frame update
    // assign players to their game pieces
    void Start()
    {
        player1 = GameObject.Find("Blue");
        player2 = GameObject.Find("Green");
        player3 = GameObject.Find("Purple");
        player4 = GameObject.Find("Red");

        player1.GetComponent<FollowPath>().moveAllowed = false;
        player2.GetComponent<FollowPath>().moveAllowed = false;
        player3.GetComponent<FollowPath>().moveAllowed = false;
        player4.GetComponent<FollowPath>().moveAllowed = false;

        player1.GetComponent<FollowPath>().skipTurn = false;
        player2.GetComponent<FollowPath>().skipTurn = false;
        player3.GetComponent<FollowPath>().skipTurn = false;
        player4.GetComponent<FollowPath>().skipTurn = false;

        cards = new List<CardClass>();
        Cfactory = CardFactory.Instance; //Singleton pattern 
        CardClass c0 = Cfactory.createCard("regular","blue",2);
        cards.Add(c0);
        CardClass c1 = Cfactory.createCard("regular","blue",1);
        cards.Add(c1);
        CardClass c2 = Cfactory.createCard("special","candycane",1);
        cards.Add(c2);
        CardClass c3 = Cfactory.createCard("regular","green",2);
        cards.Add(c3);
        CardClass c4 = Cfactory.createCard("special","gingerbread",1);
        cards.Add(c4);
        CardClass c5 = Cfactory.createCard("regular","green",1);
        cards.Add(c5);
        CardClass c6 = Cfactory.createCard("special","gumdrop",1);
        cards.Add(c6);
        CardClass c7 = Cfactory.createCard("special","ice cream",1);
        cards.Add(c7);
        CardClass c8 = Cfactory.createCard("special","licorice",1);
        cards.Add(c8);
        CardClass c9 = Cfactory.createCard("special","lollipop",1);
        cards.Add(c9);
        CardClass c10 = Cfactory.createCard("regular","orange",2);
        cards.Add(c10);
        CardClass c11 = Cfactory.createCard("regular","orange",1);
        cards.Add(c11);
        CardClass c12 = Cfactory.createCard("regular","purple",2);
        cards.Add(c12);
        CardClass c13 = Cfactory.createCard("special","peanut",1);
        cards.Add(c13);
        CardClass c14 = Cfactory.createCard("regular","purple",1);
        cards.Add(c14);
        CardClass c15 = Cfactory.createCard("regular","red",2);
        cards.Add(c15);
        CardClass c16 = Cfactory.createCard("regular","red",1);
        cards.Add(c16);
        CardClass c17 = Cfactory.createCard("regular","yellow",2);
        cards.Add(c17);
        CardClass c18 = Cfactory.createCard("regular","yellow",1);
        cards.Add(c18);
    }

    // Update is called once per frame
    void Update()
    {
        string goalColor = cards[cardPicked].Color;
        int spacesToMove = cards[cardPicked].Spaces;

        // while (spacesToMove > 0){
        //     int currIndex = player1.GetComponent<FollowPath>().waypointIndex;
        //     player1StartWaypoint += 1;

        //     player1.GetComponent<FollowPath>().moveAllowed = false;
        // }
        if (player1.GetComponent<FollowPath>().waypointIndex > 
        player1StartWaypoint + cardPicked){
            player1.GetComponent<FollowPath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowPath>().waypointIndex - 1;
        }
        if (player2.GetComponent<FollowPath>().waypointIndex > 
        player2StartWaypoint + cardPicked){
            player2.GetComponent<FollowPath>().moveAllowed = false;
            player2StartWaypoint = player2.GetComponent<FollowPath>().waypointIndex - 1;
        }
        if (player3.GetComponent<FollowPath>().waypointIndex > 
        player3StartWaypoint + cardPicked){
            player3.GetComponent<FollowPath>().moveAllowed = false;
            player3StartWaypoint = player3.GetComponent<FollowPath>().waypointIndex - 1;
        }
        if (player4.GetComponent<FollowPath>().waypointIndex > 
        player4StartWaypoint + cardPicked){
            player4.GetComponent<FollowPath>().moveAllowed = false;
            player4StartWaypoint = player4.GetComponent<FollowPath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowPath>().waypointIndex == 
        player1.GetComponent<FollowPath>().waypoints.Length){
            gameOver = true;
        }
        if (player2.GetComponent<FollowPath>().waypointIndex == 
        player2.GetComponent<FollowPath>().waypoints.Length){
            gameOver = true;
        }
        if (player3.GetComponent<FollowPath>().waypointIndex == 
        player3.GetComponent<FollowPath>().waypoints.Length){
            gameOver = true;
        }
        if (player4.GetComponent<FollowPath>().waypointIndex == 
        player4.GetComponent<FollowPath>().waypoints.Length){
            gameOver = true;
        }
    }
    public static void MovePlayer(int playerToMove){
        switch (playerToMove){
            case 1:
                player1.GetComponent<FollowPath>().moveAllowed = true;
                break;
            case 2:
                player2.GetComponent<FollowPath>().moveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowPath>().moveAllowed = true;
                break;
            case 4:
                player4.GetComponent<FollowPath>().moveAllowed = true;
                break;
        }
    }
}
