using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    private static GameObject player1, player2, player3, player4;
    public static int cardPicked = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("Blue");
        player2 = GameObject.Find("Green");
        player3 = GameObject.Find("Purple");
        player4 = GameObject.Find("Red");

        player1.getComponent<FollowPath>().moveAllowed = False;
        player2.getComponent<FollowPath>().moveAllowed = False;
        player3.getComponent<FollowPath>().moveAllowed = False;
        player4.getComponent<FollowPath>().moveAllowed = False;


    }

    // Update is called once per frame
    void Update()
    {
        if (player1.getComponent<FollowPath>().waypointIndex > 
        player1StartWaypoint + cardPicked){
            player1.getComponent<FollowPath>().moveAllowed = False;
            player1StartWaypoint = player1.getComponent<FollowPath>().waypointIndex - 1;
        }
        if (player2.getComponent<FollowPath>().waypointIndex > 
        player2StartWaypoint + cardPicked){
            player2.getComponent<FollowPath>().moveAllowed = False;
            player2StartWaypoint = player2.getComponent<FollowPath>().waypointIndex - 1;
        }
        if (player3.getComponent<FollowPath>().waypointIndex > 
        player3StartWaypoint + cardPicked){
            player3.getComponent<FollowPath>().moveAllowed = False;
            player3StartWaypoint = player3.getComponent<FollowPath>().waypointIndex - 1;
        }
        if (player4.getComponent<FollowPath>().waypointIndex > 
        player4StartWaypoint + cardPicked){
            player4.getComponent<FollowPath>().moveAllowed = False;
            player4StartWaypoint = player4.getComponent<FollowPath>().waypointIndex - 1;
        }

        if (player1.getComponent<FollowPath>().waypointIndex == 
        player1.getComponent<FollowPath>().waypoints.Length){
            gameOver = True;
        }
        if (player2.getComponent<FollowPath>().waypointIndex == 
        player2.getComponent<FollowPath>().waypoints.Length){
            gameOver = True;
        }
        if (player3.getComponent<FollowPath>().waypointIndex == 
        player3.getComponent<FollowPath>().waypoints.Length){
            gameOver = True;
        }
        if (player4.getComponent<FollowPath>().waypointIndex == 
        player4.getComponent<FollowPath>().waypoints.Length){
            gameOver = True;
        }
    }
    public static void MovePlayer(int playerToMove){
        switch (playerToMove){
            case 1:
                player1.getComponent<FollowPath>().moveAllowed = True;
                break;
            case 2:
                player2.getComponent<FollowPath>().moveAllowed = True;
                break;
            case 3:
                player3.getComponent<FollowPath>().moveAllowed = True;
                break;
            case 4:
                player4.getComponent<FollowPath>().moveAllowed = True;
                break;
        }
    }
}
