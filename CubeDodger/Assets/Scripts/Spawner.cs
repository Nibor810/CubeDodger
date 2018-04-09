using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timeLeftTillNextSpawn = 2f;
    private float minSpawnTime = 2;
    private float maxSpawnTime = 10;
    public GameObject enemyPrefab;
    public Transform enemySpawn;

    // Update is called once per frame
    void Update () {
	    timeLeftTillNextSpawn -= Time.deltaTime;
        if (timeLeftTillNextSpawn < 0 && PlayerExist())
        {
            timeLeftTillNextSpawn = (Random.value * (maxSpawnTime-minSpawnTime)) + minSpawnTime;
            Spawn();
        }
	}

    bool PlayerExist()
    {
        return GameObject.Find("Player") != null;
    }

    void Spawn()
    {
        Instantiate(
        enemyPrefab,
        enemySpawn.position,
        enemySpawn.rotation);
    }
}
