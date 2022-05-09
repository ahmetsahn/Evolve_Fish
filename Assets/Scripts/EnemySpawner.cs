using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> enemies;
   
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 2, 4f);
        StartCoroutine(SpeedUpSpawn());
    }

    private void SpawnEnemies()
    {
        int index = Random.Range(0, enemies.Count);
        Instantiate(enemies[index]);
    }

    IEnumerator SpeedUpSpawn()
    {
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 0, 3.5f);
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 0, 3f);
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 0, 2f);
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 0, 1f);
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 0, 0.8f);
    }
}
