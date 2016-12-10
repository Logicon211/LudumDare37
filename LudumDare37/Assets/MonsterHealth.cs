using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour {

    public int health;

    bool isDead;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        isDead = (health <= 0);
	}

    public void SetHealth(int damage)
    {
        health -= damage;
    }

    public bool IsDead()
    {
        return isDead;
    }
}
