using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairableObjectController : MonoBehaviour, IInteractable {

	private bool clicked = false;
	public RepairableObjectTaskController repairableObjecttaskController;
	private PlayerLineOfSight playerLineOfSiteController;

	// Use this for initialization
	void Start () {
		repairableObjecttaskController = GameObject.FindObjectOfType<RepairableObjectTaskController> ();
		GameObject camera = GameObject.FindGameObjectWithTag ("MainCamera");
		playerLineOfSiteController = (PlayerLineOfSight)camera.GetComponent (typeof(PlayerLineOfSight));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Interact() {
		if (!clicked && playerLineOfSiteController.GetEquipedItem() != null && playerLineOfSiteController.GetEquipedItem().CompareTag("Wrench")) {
			Debug.Log ("Clicking on Repairable Object");
			clicked = true;
			repairableObjecttaskController.decrementNumberOfRepairableObjects ();
		}
	}
}
