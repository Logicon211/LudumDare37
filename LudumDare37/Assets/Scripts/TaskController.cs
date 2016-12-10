using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour {

	private bool controlPanelTaskComplete = false;

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
}
