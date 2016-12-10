using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health;

    bool dead = false;
    
	// Use this for initialization
	void Start () {
		if (health == 0)
        {
            health = 100;
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
        {
            dead = true;
        }
	}

    public void SetHealth(int damage)
    {
        health -= damage;
        print("This is the health being reduced");
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
