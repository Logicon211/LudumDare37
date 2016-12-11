using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLineOfSight : MonoBehaviour {

	public float interactionDistance;
	RaycastHit objectInRange;
	bool isObjectInRange;
	GameObject objectInHand;
	public LayerMask colliderMask;
	public Text interactionText;

	public float throwForce = 5;

	// Use this for initialization
	void Start () {
		isObjectInRange = false;
		interactionText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (this.transform.position, this.transform.forward * interactionDistance, Color.magenta);

		IPickupable pickupableObject = null;
		IInteractable interactableObject = null;

		if (Physics.Raycast (this.transform.position, this.transform.forward, out objectInRange, interactionDistance, colliderMask)) {
//			Debug.Log ("Object in range: " + objectInRange.collider.name);

			pickupableObject = (IPickupable)objectInRange.collider.gameObject.GetComponent (typeof(IPickupable));
			interactableObject = (IInteractable)objectInRange.collider.gameObject.GetComponent (typeof(IInteractable));


			isObjectInRange = true;
			if (Input.GetKeyDown(KeyCode.E)) {
				if (objectInHand == null) {
					if (interactableObject != null) {
						interactableObject.Interact ();
					}
				}
			}

			if (Input.GetMouseButtonDown (1)) {
				if (objectInHand != null) {
					if (pickupableObject != null) {
						pickupableObject.Throw (null, this.transform.forward, throwForce);
						objectInHand = null;
					}
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

		updateInteractionText (interactableObject, pickupableObject);
	}

    public bool IsAbleToPunch()
    {
        if (objectInHand == null)
            return true;
        return false;
    }

	private void updateInteractionText(IInteractable interactable, IPickupable pickupable) {
		
		if (interactable != null && objectInHand == null) {
			interactionText.text = "[E] to interact";
		} else if (pickupable != null && objectInHand == null) {
			interactionText.text = "[E] to pickup";
		} else { 
			interactionText.text = "";
		}
	}
}
