using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour
{
  
    private Vector3 mousePos;
    public Vector3 MousePos => mousePos;

    public void GetInteractInput()
    {
        if (Input.touchCount > 0)
        {
            Game_Events_System.instance.LoadInput(mousePos);
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
        }
    }

   
}
