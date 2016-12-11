using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour, IInteractable {

	private bool clicked = false;
	private TaskController parentController;
	private GameObject[] lights;

	// Use this for initialization
	void Start () {
		parentController = GameObject.FindObjectOfType<TaskController> ();
		lights = GameObject.FindGameObjectsWithTag ("Light");
		foreach (GameObject light in lights) {
			light.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Interact () {
		if (!clicked) {
			Debug.Log ("Hit Light Switch");
			this.transform.Rotate (new Vector3 (1, 0, 0), 180);
			clicked = true;
			Debug.Log ("Light switch task complete");
			foreach (GameObject light in lights) {
				light.SetActive (true);
			}
			parentController.TriggerLightSwitchTaskComplete ();
		}
	}
}
