using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public int maxEnemies;
    public float spawnTime;
    public GameObject skeleton;

    float elapsedTime = 0.0f;
    int spawnPoint = 0;
    int enemyCount = 0;

    EnemySpawn[] spawnPoints;
    
    // Use this for initialization
    void Start()
    {
        spawnPoints = GetComponentsInChildren<EnemySpawn>();
    }

    // Update is called once per frame
    void Update () {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnTime && enemyCount < maxEnemies)
        {
            AddEnemy();
            enemyCount++;
            print(enemyCount);
            elapsedTime = 0.0f;
        }
	}

    void AddEnemy()
    {
        spawnPoint = Random.Range(0, spawnPoints.Length);
        spawnPoints[spawnPoint].SpawnEnemy(skeleton);
    }

    public void DecrementCounter()
    {
        enemyCount--;
        if (enemyCount < 0)
            enemyCount = 0;
    }
}
