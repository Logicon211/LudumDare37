using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanelTaskController : MonoBehaviour {

	private TaskController parentController;
	private int numberOfControlPanels;
	private bool taskComplete = false;

	// Use this for initialization
	void Start () {
		numberOfControlPanels = GameObject.FindGameObjectsWithTag ("ControlPanel").Length;
		parentController = GameObject.FindObjectOfType<TaskController> ();
		checkTaskComplete ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void decrementNumberOfPanels () {
		if (numberOfControlPanels != 0) {
			numberOfControlPanels--;
			Debug.Log ("Decremented, new number of panels: " + numberOfControlPanels);
			checkTaskComplete ();
		}
	}

	private void checkTaskComplete () {
		if (numberOfControlPanels == 0 && !taskComplete) {
			taskComplete = true;
			Debug.Log ("Control Panel task complete");
			parentController.triggerControlPanelTaskComplete ();
		}
	}
}
