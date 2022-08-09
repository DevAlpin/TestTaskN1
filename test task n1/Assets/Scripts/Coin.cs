using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        PlayerStates.OnCoinCollect.AddListener(OnCollect);
    }

    void OnCollect() 
    {

        Destroy(gameObject);

    }
}
