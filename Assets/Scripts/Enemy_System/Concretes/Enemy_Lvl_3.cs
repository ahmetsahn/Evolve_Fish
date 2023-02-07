using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lvl_3 : Enemy_Base
{
    private void Awake()
    {
        SetComponent();
    }

    private void OnEnable()
    {
        
        enemy_Transform.SetFlipRender(enemy_Renderer.SpriteRenderer);
    }


    private void Update()
    {
        enemy_Move.Move(enemy_Transform.MoveDirection);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            if (collision.GetComponent<Player>().CurrentState == collision.GetComponent<Player>().GreenFishState ||
                collision.GetComponent<Player>().CurrentState == collision.GetComponent<Player>().BlueFishState ||
                collision.GetComponent<Player>().CurrentState == collision.GetComponent<Player>().RedFishState)
            {
                Destroy(collision.gameObject);
               
                Game_Events_System.instance.LoadDie();
            }


        }

        base.OnTriggerEnter2D(collision);


    }

  
}
