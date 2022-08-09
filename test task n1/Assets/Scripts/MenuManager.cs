using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public List<GameObject> Menus = new List<GameObject>();

    private void Start()
    {
        PlayerStates.OnLose.AddListener(LoadMenu);

        UiManager.OnWin.AddListener(LoadMenu);
    }

    void LoadMenu(int number) 
    {

        Menus[number].SetActive(true);
    } 


}
