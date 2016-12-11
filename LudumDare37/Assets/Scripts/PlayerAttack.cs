using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    Animator ani;   // Animation component
    PlayerLineOfSight los;
    FistScript fist;
    GameObject target;
    MonsterHealth monsterHealth;
    AudioSource audio;

    public int attackDamage;
    public AudioClip damaged;

    bool startTimer = false;
    float punchTimer = .2f;
    int counter = 0;

    // Use this for initialization
    void Start () {
        ani = GetComponentInChildren<Animator>();
        los = GetComponentInChildren<PlayerLineOfSight>();
        fist = GetComponentInChildren<FistScript>();
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && los.IsAbleToPunch())
        {
            if (!ani.GetBool("Punch"))
            {
                audio.PlayOneShot(damaged, 0.7f);
                startTimer = true;
                punchTimer = .2f;
            }
            ani.SetBool("Punch", true);
        }
        if (startTimer)
            punchTimer -= Time.deltaTime;
        CheckAttacking();
	}

    void CheckAttacking()
    {

        if ( ani.GetBool("Punch") && fist.GetIsHitting() != null && ani.GetBool("Punching") == false && punchTimer <= 0.0f && punchTimer >= -.2f)
        {
            target = fist.GetIsHitting().gameObject;
            monsterHealth = target.GetComponent<MonsterHealth>();
            monsterHealth.SetHealth(attackDamage);
            ani.SetBool("Punching", true);
            punchTimer = .2f;
            startTimer = false;
        }
    }

    void DecrementTimer()
    {

    }
}
