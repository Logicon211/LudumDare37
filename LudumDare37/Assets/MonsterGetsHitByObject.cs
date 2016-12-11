using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGetsHitByObject : MonoBehaviour {

    MonsterHealth health;

	// Use this for initialization
	void Start () {
        health = gameObject.GetComponent<MonsterHealth>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        GameObject g = other.collider.gameObject;
        if (g.GetComponent<GenericPickupableObject>() != null)
        {
            float vel = other.relativeVelocity.magnitude;
            float mass = g.GetComponent<Rigidbody>().mass;

            if (mass*vel >= 4.0f)
            {
                health.SetHealth(10);
            }
        }
    }
}
