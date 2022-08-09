using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStates : MonoBehaviour
{

    public static UnityEvent OnCoinCollect = new UnityEvent();
    
    public static UnityEvent<int> OnLose = new UnityEvent<int>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.gameObject.GetComponent<Coin>() != null)
        {
            OnCoinCollect.Invoke();

        }

        if (collision.gameObject.GetComponent<Spike>() != null)
        {
            OnLose.Invoke(1);
            gameObject.SetActive(false);
        }

    }

}
