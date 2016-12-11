﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int health;
	public GameObject redDeathOverlayObject;
	public AudioClip player_hurt;

	AudioSource audio;
	private Image redDeathImage;

    bool dead = false;
    
	// Use this for initialization
	void Start () {
		redDeathImage = redDeathOverlayObject.GetComponent<Image> ();
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        dead = (health <= 0);
		if (dead) {
			redDeathImage.enabled = true;
		}
	}

    public void SetHealth(int damage)
    {
        health -= damage;

		float temp;
		Color temp1;
		//temp = redDeathImage.color;
		temp= (1- (float)health/100);
		temp1 = redDeathImage.color;
		temp1.a = temp;
		//redDeathImage.color.a = temp;

		redDeathImage.enabled = true;
		redDeathImage.color = temp1;
		Debug.Log("setting health to" + health);
		Debug.Log("setting temp to" + temp);

		audio.PlayOneShot(player_hurt, 0.7f);
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
