using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lvl_1 : Enemy_Base,IEdibleFish
{
  

    private void OnEnable()
    {
        enemy_Transform.SetFlipRender(enemy_Renderer.SpriteRenderer);
    }


    private void Update()
    {
        enemy_Move.Move(enemy_Transform.MoveDirection);
    }

    


    public void Eat(Player player,Collider2D collision)
    {
        if(player.CurrentState == player.GreenFishState)
        {
            Destroy(collision.gameObject);
            Game_Events_System.instance.LoadDie();
        }

        else
        {
            Game_Events_System.instance.LoadIncrementScore(2);
            Game_Events_System.instance.LoadPrintScore();
            Game_Events_System.instance.LoadToFillImageBar(2);
            Game_Events_System.instance.LoadEatSound();
            gameObject.SetActive(false);
        }

        
    }

    
}
