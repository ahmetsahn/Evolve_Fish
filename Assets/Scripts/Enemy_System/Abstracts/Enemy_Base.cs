using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy_Base : MonoBehaviour
{

    protected Enemy_Movement enemy_Move;
    protected Enemy_Transform enemy_Transform;
    protected Enemy_Renderer enemy_Renderer;


    public void SetComponent()
    {
        enemy_Move = GetComponent<Enemy_Movement>();
        enemy_Transform = GetComponent<Enemy_Transform>();
        enemy_Renderer = GetComponent<Enemy_Renderer>();
    }



    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ExitScreenCollider"))
        {
            gameObject.SetActive(false);
        }
    }

}
