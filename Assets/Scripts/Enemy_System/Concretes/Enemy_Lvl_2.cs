using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lvl_2 : Enemy_Base
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
                collision.GetComponent<Player>().CurrentState == collision.GetComponent<Player>().BlueFishState)
            {
                Destroy(collision.gameObject);
               
                Game_Events_System.instance.LoadDie();
            }


            else
            {
                Game_Events_System.instance.LoadIncrementScore(4);
                Game_Events_System.instance.LoadPrintScore();
                Game_Events_System.instance.LoadToFillImageBar(4);
                Game_Events_System.instance.LoadEatSound();
                gameObject.SetActive(false);
            }

            
        }

        base.OnTriggerEnter2D(collision);
    }
}
