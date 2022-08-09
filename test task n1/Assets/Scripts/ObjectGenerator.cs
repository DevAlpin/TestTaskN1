using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjectPrefab;

    [SerializeField]
    private int ObjectCount;

    [SerializeField]
    private float DeadZone;

    private List<GameObject> ObjectsPool = new List<GameObject>();

    [SerializeField]
    private int seed = 0;

    private void Start()
    {
        Random.InitState(seed);

        for (int i = 0; i < ObjectCount; i++) 
        {

            ObjectsPool.Add(ObjectPrefab);
            
            var obj = Instantiate(ObjectsPool[i],transform);

            for (int j = 0; j < ObjectCount; j++) 
            {
                for (int k = 0; k < ObjectCount; k++)
                {
                   
                    obj.transform.position = new Vector2(Random.Range(-10f, 10f),Random.Range(-10f, 10f));

                }
            }


        }

    }


}
