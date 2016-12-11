using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour {

	private bool controlPanelTaskComplete = false;
	private bool nukeTaskComplete = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool getControlPanelTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void triggerControlPanelTaskComplete() {
		controlPanelTaskComplete = true;
		//Update UI;
	}

	public bool getNukeTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void triggerNukeTaskComplete() {
		nukeTaskComplete = true;
		//Update UI;
	}
}
