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
        yield return new WaitForSeconds(14);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 4, 3.5f);
        yield return new WaitForSeconds(14);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 3.5f, 3f);
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 3, 2f);
        yield return new WaitForSeconds(14);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 2, 1f);
        yield return new WaitForSeconds(15);
        CancelInvoke();
        InvokeRepeating("SpawnEnemies", 1, 0.8f);
    }
}
