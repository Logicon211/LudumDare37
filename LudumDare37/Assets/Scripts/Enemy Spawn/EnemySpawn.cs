using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public int maxEnemies;

    EnemySpawn[] spawnPoints;

	// Use this for initialization
	void Start () {
        spawnPoints = GetComponentsInChildren<EnemySpawn>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
