using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField]
    private float speed = 0;
    
    [SerializeField]
    private float delta = 0;

    public static UnityEvent OnReachPoint = new UnityEvent();

    [System.NonSerialized]
    public Vector2 CurTarget;


    private void Start()
    {
    
        WayPointList.OnNeedWayPoint.AddListener(NewTarget);
    }





    void NewTarget(GameObject target) 
    {
      
        CurTarget = target.transform.position;
      
    }
    

    private void MoveToTarget() 
    {


        transform.position = Vector2.Lerp(transform.position, CurTarget, speed * Time.fixedDeltaTime);

        if (Vector2.Distance(CurTarget, transform.position) < delta)
        {
             
            
            OnReachPoint.Invoke();
         
        }
    }

    private void Update()
    {
    
        MoveToTarget();
        
      
    }

}
