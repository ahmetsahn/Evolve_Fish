using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEnemy : MonoBehaviour
{
    Rigidbody2D rb;
    private int xDestroyRange = -13;
    private float ySpawnRange = 4.5f;
    private int xSpawnPosition = 15;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = RandomSpawnPosition();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        DestroyRange();
    }

    private void Move()
    {
        rb.AddForce(Vector2.left * 30 * Time.deltaTime);
    }

    private void DestroyRange()
    {
        if(transform.position.x < xDestroyRange)
        {
            Destroy(gameObject);
        }
    }

    private Vector2 RandomSpawnPosition()
    {
        return new Vector3(xSpawnPosition, Random.Range(-ySpawnRange, ySpawnRange));
    }
}

