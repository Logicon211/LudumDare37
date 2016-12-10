using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPickupableObject : MonoBehaviour, IPickupable {

	Collider collider;

	// Use this for initialization
	void Start () {
		collider = GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pickup (GameObject parent) {
		SetParent (parent);
		collider.attachedRigidbody.useGravity = false;
		collider.attachedRigidbody.isKinematic = true;
	}

	public void Release(GameObject parent) {
		SetParent (parent);
		collider.attachedRigidbody.useGravity = true;
		collider.attachedRigidbody.isKinematic = false;
	}

	private void SetParent(GameObject parent) {
		if (parent != null) {
			this.transform.parent = parent.transform;
		} else {
			this.transform.parent = null;
		}
	}
}
