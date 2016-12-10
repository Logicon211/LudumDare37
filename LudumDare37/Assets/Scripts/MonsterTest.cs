using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class MonsterTest : MonoBehaviour {

    Animator ani;   // Animation component
    Transform plTransform;

    public GameObject player;
    public float speed;

    float distance;
    bool walking = false;

    float ATTACK_RANGE = 0.3f;

	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
        plTransform = player.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(transform.position, plTransform.position);

        // Checking to see if up arrow is up or down, will determine if the walk animation is to be played
        if (distance > ATTACK_RANGE) { 
            ani.SetBool("Walk", true);
            walking = true;
        }
        else
        {
            ani.SetBool("Walk", false);
            walking = false;
            ani.SetBool("Attack", true);
        }
        CheckKeyPresses();
        transform.LookAt(plTransform);
	}

    void CheckKeyPresses()
    {
        if (walking == true && ani.GetBool("Attack") == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
