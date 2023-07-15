using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public GameObject[] waypoints;
    private int currentWaypountIdx = 0;
    public float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        if(Vector2.Distance(waypoints[currentWaypountIdx].transform.position, transform.position) < .1f) {
            currentWaypountIdx++;
            if(currentWaypountIdx >= waypoints.Length) {
                currentWaypountIdx = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypountIdx].transform.position, Time.deltaTime * speed);
    }
}
