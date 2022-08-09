
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{

    public static Action<Vector2> OnScreenTouch;

    [SerializeField]
    private Camera cam;

    private bool CanInput = true;
    private void Start()
    {
        PlayerStates.OnLose.AddListener(CantInput);
        UiManager.OnWin.AddListener(CantInput);
    }

    void ScreenTouch() 
    {

       /* if (Input.GetMouseButton(0))
        {
            if (OnScreenTouch != null)
                OnScreenTouch.Invoke(cam.ScreenToWorldPoint(Input.mousePosition));
         
        }*/

        if (Input.touchCount > 0)
        {
            if(OnScreenTouch != null)
                OnScreenTouch.Invoke(cam.ScreenToWorldPoint(Input.GetTouch(0).position));
            Debug.Log("00");
        }
    
    }


    private void CantInput(int i) 
    {
        CanInput = false;
    }


    private void Update()
    {
        if(CanInput)
        ScreenTouch();
    }


}
