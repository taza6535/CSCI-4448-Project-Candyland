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
    public CardFactory CFactory;
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

        //initializing cards
        cards = new List<CardClass>();
        CFactory = CardFactory.Instance; //Singleton pattern 
        for(int i=0; i<4; i++){
            CardClass bd = CFactory.createCard("regular", "blue", 2);
            cards.Add(bd);
        }
        for(int i=0; i<6; i++){
            CardClass bs = CFactory.createCard("regular", "blue", 1);
            cards.Add(bs);
        }
        
        CardClass candycane = CFactory.createCard("special","candycane",1);
        cards.Add(candycane);

        for(int i=0; i<4; i++){
            CardClass gd = CFactory.createCard("regular", "green", 2);
            cards.Add(gd);
        }
        CardClass gingerbread = CFactory.createCard("special","candycane",1);
        cards.Add(gingerbread);
        for(int i=0; i<6; i++){
            CardClass gs = CFactory.createCard("regular", "green", 1);
            cards.Add(gs);
        }


        CardClass gumdrop = CFactory.createCard("special","candycane",1);
        CardClass icecream = CFactory.createCard("special","candycane",1);
        CardClass licorice = CFactory.createCard("special","candycane",1);
        CardClass lollipop = CFactory.createCard("special","candycane",1);
        cards.Add(gumdrop);
        cards.Add(icecream);
        cards.Add(licorice);
        cards.Add(lollipop);

        for(int i=0; i<4; i++){
            CardClass od = CFactory.createCard("regular", "orange", 2);
            cards.Add(od);
        }
        for(int i=0; i<6; i++){
            CardClass os = CFactory.createCard("regular", "orange", 1);
            cards.Add(os);
        }

        for(int i=0; i<4; i++){
            CardClass pd = CFactory.createCard("regular", "purple", 2);
            cards.Add(pd);
        }
        CardClass peanut = CFactory.createCard("special","candycane",1);
        cards.Add(peanut);
        for(int i=0; i<6; i++){
            CardClass ps = CFactory.createCard("regular", "purple", 1);
            cards.Add(ps);
        }

        for(int i=0; i<4; i++){
            CardClass rd = CFactory.createCard("regular", "red", 2);
            cards.Add(rd);
        }
        for(int i=0; i<6; i++){
            CardClass rs = CFactory.createCard("regular", "red", 1);
            cards.Add(rs);
        }

        for(int i=0; i<4; i++){
            CardClass yd = CFactory.createCard("regular", "yellow", 2);
            cards.Add(yd);
        }
        for(int i=0; i<6; i++){
            CardClass ys = CFactory.createCard("regular", "yellow", 1);
            cards.Add(ys);
        }



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

        // while(spacesToMove>0){
        //     int currIndex = player1.GetComponent<FollowPath>().waypointIndex - 1;
        //     if(currIndex == -1){
        //         currIndex = 0;
        //     }
        //     //regular moves
        //     //for(int i=currIndex; i<gameBoard.Length; i++){
        //         if(string.Equals(gameBoard[currIndex],goalColor)){
        //             spacesToMove--;
        //             if (player1.GetComponent<FollowPath>().waypointIndex > 
        //             player1StartWaypoint + 1){
        //                 //player1.GetComponent<FollowPath>().moveAllowed = false;
        //                 player1StartWaypoint = player1.GetComponent<FollowPath>().waypointIndex-1;
        //             }
        //             if (player2.GetComponent<FollowPath>().waypointIndex > 
        //             player2StartWaypoint +1){
        //                 //player2.GetComponent<FollowPath>().moveAllowed = false;
        //                 player2StartWaypoint = player2.GetComponent<FollowPath>().waypointIndex - 1;
        //             }
        //             if (player3.GetComponent<FollowPath>().waypointIndex > 
        //             player3StartWaypoint+1){
        //                 //player3.GetComponent<FollowPath>().moveAllowed = false;
        //                 player3StartWaypoint = player3.GetComponent<FollowPath>().waypointIndex - 1;
        //             }
        //             if (player4.GetComponent<FollowPath>().waypointIndex > 
        //             player4StartWaypoint+1){
        //                 //player4.GetComponent<FollowPath>().moveAllowed = false;
        //                 player4StartWaypoint = player4.GetComponent<FollowPath>().waypointIndex - 1;
        //             }
        //             break;
        //         }
        //     //}
        // }
        // player1.GetComponent<FollowPath>().moveAllowed = false;
        // player2.GetComponent<FollowPath>().moveAllowed = false;
        // player3.GetComponent<FollowPath>().moveAllowed = false;
        // player4.GetComponent<FollowPath>().moveAllowed = false;

        if (player1.GetComponent<FollowPath>().waypointIndex > 
        player1StartWaypoint + spacesToMove){
            player1.GetComponent<FollowPath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowPath>().waypointIndex-1;
        }
        if (player2.GetComponent<FollowPath>().waypointIndex > 
        player2StartWaypoint + spacesToMove){
            player2.GetComponent<FollowPath>().moveAllowed = false;
            player2StartWaypoint = player2.GetComponent<FollowPath>().waypointIndex - 1;
        }
        if (player3.GetComponent<FollowPath>().waypointIndex > 
        player3StartWaypoint + spacesToMove){
            player3.GetComponent<FollowPath>().moveAllowed = false;
            player3StartWaypoint = player3.GetComponent<FollowPath>().waypointIndex - 1;
        }
        if (player4.GetComponent<FollowPath>().waypointIndex > 
        player4StartWaypoint + spacesToMove){
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
