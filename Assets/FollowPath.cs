using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Transform[] waypoints;
    private float moveSpeed = 9f;
    public int waypointIndex = 0;
    public bool moveAllowed = false;
    // if player lands on licorice
    public bool skipTurn = false;

    private void Start(){
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update(){
        if (moveAllowed & !skipTurn){
            Move();
        }
    }

    private void Move(){
        if (waypointIndex < waypoints.Length){
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);
            
            if (transform.position == waypoints[waypointIndex].transform.position){
                waypointIndex += 1;
            }
        }
        // else {
        //     transform.position = Vector2.MoveTowards(transform.position,
        //     waypoints[waypoint.Length-1].transform.position,
        //     moveSpeed * Time.deltaTime);
        // }
    }
}
