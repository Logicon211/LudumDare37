using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour {

    AudioSource audio;

    public int health;
    public AudioClip damageSound;

    bool isDead;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
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
