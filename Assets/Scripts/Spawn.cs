using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Spawn : MonoBehaviour
{
    public Enemigo enemies;

    [SerializeField]
    private float timeSpawn = 1;

    [SerializeField]
    private float repeatSpawnRate = 3;

    public Transform xRangeLeft;
    public Transform xRangeRight;

    public Transform yRangeUp;
    public Transform yRangeDown;

    void Start()
    {
        InvokeRepeating("SpawnEnemies",timeSpawn,repeatSpawnRate);
    }
   

    public void SpawnEnmies()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject enemie = Instantiate(
                enemies,
                spawnPosition,
                gameObject.transform.rotation
            );
    }
}
