using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    Animator ani;   // Animation component
    PlayerLineOfSight los;
    FistScript fist;
    GameObject target;
    MonsterHealth monsterHealth;

    public int attackDamage;

    // Use this for initialization
    void Start () {
        ani = GetComponentInChildren<Animator>();
        los = GetComponentInChildren<PlayerLineOfSight>();
        fist = GetComponentInChildren<FistScript>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && los.IsAbleToPunch())
        {
            ani.SetBool("Punch", true);
        }
        CheckAttacking();
	}

    void CheckAttacking()
    {
        if ( ani.GetBool("Punch") && fist.GetIsHitting() != null && ani.GetBool("Punching") == false)
        {
            target = fist.GetIsHitting().gameObject;
            monsterHealth = target.GetComponent<MonsterHealth>();
            monsterHealth.SetHealth(attackDamage);
            ani.SetBool("Punching", true);
        }
    }
}
