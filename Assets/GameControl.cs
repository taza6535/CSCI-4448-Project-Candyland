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
    public static bool gameOver = false;
    // Start is called before the first frame update
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


    }

    // Update is called once per frame
    void Update()
    {
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
