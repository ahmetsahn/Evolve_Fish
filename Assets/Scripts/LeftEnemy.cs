using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEnemy : MonoBehaviour
{
    Rigidbody2D rb;
    private int xRange = 13;
    private float ySpawnRange = 4.2f;
    private int xSpawnPosition = -15;

    private void Awake()
    {
        transform.position = RandomSpawnPosition();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        DestroyRange();
    }

 
    private void DestroyRange()
    {
        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        rb.AddForce(Vector2.right * 30 * Time.deltaTime);
    }

    private Vector2 RandomSpawnPosition()
    {
        return new Vector3(xSpawnPosition, Random.Range(-ySpawnRange, ySpawnRange));
    }

}

