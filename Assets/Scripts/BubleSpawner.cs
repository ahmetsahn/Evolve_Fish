using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject baloncukPrefab;
    [SerializeField] private Transform[] spawnPoints;

    private void Start()
    {
        InvokeRepeating("spawn", 0, 2f);
    }

    private void spawn()
    {
        int randPos = Random.Range(0, spawnPoints.Length);
        GameObject newEnemy = Instantiate(baloncukPrefab, spawnPoints[randPos].position, spawnPoints[randPos].rotation);
    }
}
