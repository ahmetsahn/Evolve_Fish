using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Transform : MonoBehaviour
{
    private float ySpawnMaxRange = 4.2f;
    private float ySpawnMinRange = -2.9f;
    private float xSpawnPosition;
    private float xRightSpawnPosition = 15;
    private float xLeftSpawnPosition = -15;
    private int spawnPos;
    private Vector2 moveRight = Vector2.right;
    private Vector2 moveLeft = Vector2.left;
    private Vector2 moveDirection;
    public Vector2 MoveDirection => moveDirection;


    private void OnEnable()
    {
        SetStartDirection();
        SetDirection();
        SetStartXPosition();
        SetStartPosition();
    }

    private void SetStartDirection()
    {
        spawnPos = Random.Range(0, 2);
    }

    public void SetStartPosition()
    {
        transform.position = new Vector2(xSpawnPosition, Random.Range(ySpawnMinRange, ySpawnMaxRange));
    }

    private void SetStartXPosition()
    {
        if (spawnPos == 0)
        {
            xSpawnPosition = xLeftSpawnPosition;
        }

        else
        {
            xSpawnPosition = xRightSpawnPosition;

        }
    }

    public void SetDirection()
    {
        if (spawnPos == 0)
        {
            moveDirection = moveRight;
        }

        else
        {
            moveDirection = moveLeft;

        }
    }
    
    public void SetFlipRender(SpriteRenderer _spriteRenderer)
    {
        {
            if (spawnPos == 0)
            {
                _spriteRenderer.flipX = false;
            }

            else
            {
                _spriteRenderer.flipX = true;
            }
        }
    }
}
