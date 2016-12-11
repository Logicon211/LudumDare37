using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int health;
	public GameObject redDeathOverlayObject;

	private Image redDeathImage;

    bool dead = false;
    
	// Use this for initialization
	void Start () {
		redDeathImage = redDeathOverlayObject.GetComponent<Image> ();
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
