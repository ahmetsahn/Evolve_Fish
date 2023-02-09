using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn_Manager : MonoBehaviour,ISpawn_Object
{
   
    private void Start()
    {
        InvokeRepeating("SpawnObject", 1, 4);
        StartCoroutine(SpeedUpSpawn());
    }

    

    IEnumerator SpeedUpSpawn()
    {
        yield return new WaitForSeconds(12);
        CancelInvoke();
        InvokeRepeating("SpawnObject", 0, 3f);
        yield return new WaitForSeconds(12);
        CancelInvoke();
        InvokeRepeating("SpawnObject", 0, 2f);
        yield return new WaitForSeconds(12);
        CancelInvoke();
        InvokeRepeating("SpawnObject", 0, 1f);
        yield return new WaitForSeconds(12);
        CancelInvoke();
        InvokeRepeating("SpawnObject", 0, 0.5f);
    }

    public void SpawnObject()
    {
        GameObject obj = Enemy_Object_Pool.instance.GetPooledObject();
        if (obj != null)
        {

            obj.SetActive(true);
        }
    }
}
