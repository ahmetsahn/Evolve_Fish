using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy_Base : MonoBehaviour
{
    [SerializeField]
    protected Enemy_Movement enemy_Move;
    [SerializeField]
    protected Enemy_Transform enemy_Transform;
    [SerializeField]
    protected Enemy_Renderer enemy_Renderer;


    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ExitScreenCollider"))
        {
            gameObject.SetActive(false);
        }
    }

   

}
