using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lvl_3 : Enemy_Base,IEdibleFish
{
    

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
        Destroy(collision.gameObject);
        Game_Events_System.instance.LoadDie();
    }
}

  

