using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health;
    
	// Use this for initialization
	void Start () {
		if (health == 0)
        {
            health = 100;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetHealth(int damage)
    {
        health += damage;
    }
}
