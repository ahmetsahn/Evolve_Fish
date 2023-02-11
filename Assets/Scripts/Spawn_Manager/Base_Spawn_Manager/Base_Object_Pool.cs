using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Object_Pool : MonoBehaviour
{
  
    [SerializeField]
    protected List<GameObject> poolObjects = new();

    public GameObject GetPooledObject()
    {

        for (int i = 0; i < poolObjects.Count; i++)
        {
            if (!poolObjects[i].activeSelf)
            {
                return poolObjects[i];
            }
        }

        return null;

    }
}
