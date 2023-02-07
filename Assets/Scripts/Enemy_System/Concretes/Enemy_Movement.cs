using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    private float movementSpeed = 4;
    public void Move(Vector2 vector)
    {
        transform.Translate(vector * movementSpeed * Time.deltaTime);
    }
}
