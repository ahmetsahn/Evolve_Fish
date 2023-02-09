using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lvl_2 : Enemy_Base,IEdibleFish
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

   



    public void Eat(Player player, Collider2D collision)
    {
        if (player.CurrentState == player.RedFishState)
        {
            Game_Events_System.instance.LoadIncrementScore(4);
            Game_Events_System.instance.LoadPrintScore();
            Game_Events_System.instance.LoadToFillImageBar(4);
            Game_Events_System.instance.LoadEatSound();
            gameObject.SetActive(false);
        }

        else
        {
            Destroy(collision.gameObject);
            Game_Events_System.instance.LoadDie();
        }

       
    }
}
