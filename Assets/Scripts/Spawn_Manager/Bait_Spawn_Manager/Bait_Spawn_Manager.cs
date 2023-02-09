using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bait_Spawn_Manager : MonoBehaviour,ISpawn_Object
{
   

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, 3);
    }


    public void SpawnObject()
    {
        GameObject obj = Bait_Object_Pool.instance.GetPooledObject();
        if (obj != null)
        {

            obj.SetActive(true);
        }
    }
}
