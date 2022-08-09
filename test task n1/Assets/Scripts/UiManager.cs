using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class UiManager : MonoBehaviour
{

    public static UnityEvent<int> OnWin = new UnityEvent<int>();

    int CoinCount = 0;

    [SerializeField]
    private int CoinsToWin = 0;


    public TextMeshProUGUI Score;
    private void Start()
    {
        PlayerStates.OnCoinCollect.AddListener(CoinUpdate);
    }


    void CoinUpdate() 
    {
       
        CoinCount++;
        Score.text =  " " + CoinCount;

        if (CoinCount >= CoinsToWin) 
        {
            OnWin.Invoke(0);
        }
        
    }
        
        




}
