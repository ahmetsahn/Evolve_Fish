using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Base_Player 
{
    public virtual void EnterState(Player player)
    {

    }
    public abstract void OnTrigger(Player player);
    

}
