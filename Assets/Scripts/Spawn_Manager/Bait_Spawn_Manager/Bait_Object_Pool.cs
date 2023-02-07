using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bait_Object_Pool : Base_Object_Pool
{
    public static Bait_Object_Pool instance;

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
