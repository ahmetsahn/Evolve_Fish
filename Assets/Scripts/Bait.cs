using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bait : MonoBehaviour
{
    private int xSpawnRange = 8;
    private int ySpawnPos = 7;

    private void Start()
    {
        transform.position = RandomSpawnPosition();
    }

    private Vector2 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
