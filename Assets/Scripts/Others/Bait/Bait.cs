using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bait : MonoBehaviour,IEdible
{
    private float ySpawnPos = 6.5f;
    private float xSpawnRange = 9;

    private void OnEnable()
    {
        transform.position = new Vector3(Random.RandomRange(-xSpawnRange, xSpawnRange), ySpawnPos, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            gameObject.SetActive(false);
        }
    }

    public void Eat()
    {
        gameObject.SetActive(false);
        Game_Events_System.instance.LoadIncrementScore(1);
        Game_Events_System.instance.LoadPrintScore();
        Game_Events_System.instance.LoadToFillImageBar(1);
        Game_Events_System.instance.LoadEatSound();
    }
}
