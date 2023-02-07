using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public void Move(Vector3 _mousePos)
    {
        transform.position = Vector3.Lerp(transform.position, _mousePos, Time.deltaTime);
        transform.right = _mousePos - transform.position;

    }
}
