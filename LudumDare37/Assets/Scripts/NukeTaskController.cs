using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeTaskController : MonoBehaviour {

	private TaskController parentController;
	private int numberOfNukes;
	private bool taskComplete = false;

	// Use this for initialization
	void Start () {
		numberOfNukes = GameObject.FindGameObjectsWithTag ("Nuke").Length;
		parentController = GameObject.FindObjectOfType<TaskController> ();
		checkTaskComplete ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void decrementNumberOfNukes () {
		if (numberOfNukes != 0) {
			numberOfNukes--;
			Debug.Log ("Decremented, new number of nukes: " + numberOfNukes);
			checkTaskComplete ();
		}
	}

	private void checkTaskComplete () {
		if (numberOfNukes == 0 && !taskComplete) {
			taskComplete = true;
			Debug.Log ("Nuke task complete");
			parentController.TriggerNukeTaskComplete ();
		}
	}
}
