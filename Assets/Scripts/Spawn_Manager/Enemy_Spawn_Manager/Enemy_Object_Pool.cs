using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Object_Pool : Base_Object_Pool
{
    public static Enemy_Object_Pool instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


}
