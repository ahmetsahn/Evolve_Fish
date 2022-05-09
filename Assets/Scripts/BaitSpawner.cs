using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject baitPrefab;
    
    private void Start()
    {
        InvokeRepeating("spawn", 2, 4f);
    }

    private void spawn()
    {
        Instantiate(baitPrefab);
    }
}
