using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLineOfSight : MonoBehaviour {

	public float interactionDistance;
	RaycastHit objectInRange;
	bool objectInHand;

	// Use this for initialization
	void Start () {
		objectInHand = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (this.transform.position, this.transform.forward * interactionDistance, Color.magenta);

		if (Physics.Raycast(this.transform.position, this.transform.forward, out objectInRange, interactionDistance)) {
//			Debug.Log ("Object in range: " + objectInRange.collider.name);
			if (Input.GetMouseButtonDown(0)) {
				IInteractable interactingWithObject = (IInteractable) objectInRange.collider.gameObject.GetComponent(typeof(IInteractable));
				if (interactingWithObject != null) {
					interactingWithObject.Interact ();
				}
			}
		}
	}
}
