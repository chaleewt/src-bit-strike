using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] Transform[] spawnLocation = default;
    [SerializeField] GameObject[] boxToSpawn = default;
    [SerializeField] float spawnTime = default, spawnDelay = default;

    int randomBox;
    int randomPos;

    private void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    }

    private void Spawn()
    {
        randomBox = Random.Range(0, 12);
        randomPos = Random.Range(0, 5);
        Instantiate(boxToSpawn[randomBox], spawnLocation[randomPos].position, Quaternion.identity);
    }
}
