using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour, IInteractable {

	private bool clicked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Interact () {
		if (!clicked) {
			Debug.Log ("Hit Light Switch");
			this.transform.Rotate (new Vector3 (1, 0, 0), 180);
			clicked = true;
		}
	}
}
