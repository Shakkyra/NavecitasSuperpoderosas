using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemies;

    public float timeSpawn = 1;

    public float repeatSpawnRate = 3;

    public Transform xRangeLeft;
    public Transform xRangeRight;

    public Transform yRangeUp;
    public Transform yRangeDown;

    void Start()
    {
        InvokeRepeating("SpawnEnmies",timeSpawn,repeatSpawnRate);
    }
   

    public void SpawnEnmies()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x,xRangeRight.position.x), Random.Range(yRangeDown.position.y,yRangeUp.position.y), 0);

        GameObject enemie = Instantiate(enemies[Random.Range(0,enemies.Length)],spawnPosition,gameObject.transform.rotation);
    }
}
