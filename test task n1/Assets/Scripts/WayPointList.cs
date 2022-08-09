using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WayPointList : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab = null;

    
    public List<GameObject> WayPoints = new List<GameObject>();

    public static UnityEvent<GameObject> OnNeedWayPoint = new UnityEvent<GameObject>();


    private void Start()
    {
        InputManager.OnScreenTouch += AddPoint;
        
        PlayerMovement.OnReachPoint.AddListener(RemovePoint);

    }



  

    private void AddPoint(Vector2 pointpos) 
    {     

        var point = Instantiate(prefab);

        point.transform.position = pointpos;
        WayPoints.Add(point);

        if (WayPoints.Count == 1) 
        {
            OnNeedWayPoint.Invoke(WayPoints[0]);
        }
     
    }

    private void RemovePoint() 
    {
     

        if (WayPoints.Count > 1) 
        {
            Destroy(WayPoints[0]);

            WayPoints.RemoveAt(0);

            OnNeedWayPoint.Invoke(WayPoints[0]);
          
        }      
  
    }
    

}
