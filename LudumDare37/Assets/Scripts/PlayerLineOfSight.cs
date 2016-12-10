using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLineOfSight : MonoBehaviour {

	public float interactionDistance;
	RaycastHit objectInRange;
	bool isObjectInRange;
	GameObject objectInHand;

	// Use this for initialization
	void Start () {
		isObjectInRange = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (this.transform.position, this.transform.forward * interactionDistance, Color.magenta);

		if (Physics.Raycast (this.transform.position, this.transform.forward, out objectInRange, interactionDistance)) {
//			Debug.Log ("Object in range: " + objectInRange.collider.name);
			isObjectInRange = true;
			if (Input.GetMouseButtonDown (0)) {
				IInteractable interactingWithObject = (IInteractable)objectInRange.collider.gameObject.GetComponent (typeof(IInteractable));
				if (interactingWithObject != null) {
					interactingWithObject.Interact ();
				}
			}

		} else {
			isObjectInRange = false;
		}

		if (Input.GetKeyDown(KeyCode.E)) {
			if (objectInHand != null) {
				((IPickupable) objectInHand.GetComponent<Collider>().gameObject.GetComponent(typeof(IPickupable))).Release (null);
				objectInHand = null;
				Debug.Log ("Release");
			} else if (isObjectInRange) {
				IPickupable interactingWithObject = (IPickupable) objectInRange.collider.gameObject.GetComponent(typeof(IPickupable));
				if (interactingWithObject != null) {
					interactingWithObject.Pickup (this.gameObject);
					objectInHand = objectInRange.collider.gameObject;
					Debug.Log ("Pickup");
				}
			} 
		}
	}
}
