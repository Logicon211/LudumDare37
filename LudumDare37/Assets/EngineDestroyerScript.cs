﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineDestroyerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		
		IDestroyable destroyableObject = (IDestroyable)other.gameObject.GetComponent (typeof(IDestroyable));
		if (destroyableObject != null) {
			destroyableObject.Destroy ();
		}
	}
}
