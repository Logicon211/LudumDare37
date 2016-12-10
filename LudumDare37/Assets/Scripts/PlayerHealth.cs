using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health;

    bool dead = false;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        dead = (health <= 0);
	}

    public void SetHealth(int damage)
    {
        health -= damage;
    }

    public int GetHealth()
    {
        return health;
    }

    public bool getDead()
    {
        return dead;
    }
}
