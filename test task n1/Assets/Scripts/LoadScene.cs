using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private int SceneNumber = 0;


    public void SceneLoad() 
    {
        SceneManager.LoadScene(SceneNumber);
    }

}
