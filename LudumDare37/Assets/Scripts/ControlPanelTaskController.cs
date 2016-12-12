using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanelTaskController : MonoBehaviour {

	private TaskController parentController;
	private int numberOfControlPanels;
	private bool taskComplete = false;

	private GameObject consoleInstructions;
	private GameObject consoleInstructionsDone;

	// Use this for initialization
	void Start () {
		consoleInstructions = transform.FindChild ("ConsoleInstructions").gameObject;
		consoleInstructionsDone = transform.FindChild ("ConsoleInstructionsDone").gameObject;

		consoleInstructionsDone.SetActive (false);

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
			parentController.TriggerControlPanelTaskComplete ();

			consoleInstructionsDone.SetActive (true);
			consoleInstructions.SetActive (false);
		}
	}
}
