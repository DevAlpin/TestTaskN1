using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRender : MonoBehaviour
{
    [SerializeField]
    private WayPointList waypoints;

    [SerializeField]
    private PlayerMovement player;



    void DrawPath()
    {

        player.GetComponent<LineRenderer>().SetPosition(0, player.transform.position);

        player.GetComponent<LineRenderer>().SetPosition(1, player.CurTarget);



        if (waypoints.WayPoints.Count > 1)
        {
            for (int i = 0; i < waypoints.WayPoints.Count - 1; i++)
            {
                waypoints.WayPoints[i].GetComponent<LineRenderer>().SetPosition(0, waypoints.WayPoints[i].transform.position);
                waypoints.WayPoints[i].GetComponent<LineRenderer>().SetPosition(1, waypoints.WayPoints[i+1].transform.position);
            }
        }
    }

    private void Update()
    {

        DrawPath();

    }
}
