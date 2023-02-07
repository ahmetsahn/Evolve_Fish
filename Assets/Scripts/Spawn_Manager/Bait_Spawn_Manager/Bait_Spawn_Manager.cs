using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bait_Spawn_Manager : Base_Spawn_Manager
{
    
    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, 3);
    }


    protected override void SpawnObject()
    {
        GameObject obj = Bait_Object_Pool.instance.GetPooledObject();
        if (obj != null)
        {
            
            obj.SetActive(true);
        }
    }
}
