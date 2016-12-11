using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskController : MonoBehaviour {

	private bool lightSwitchTaskComplete = false;
	private bool controlPanelTaskComplete = false;
	private bool nukeTaskComplete = false;

	public Text taskListTitle;
	public Text lightSwitchTaskText;
	public Text controlPanelTaskText;
	public Text nukeTaskText;

	// Use this for initialization
	void Start () {
		taskListTitle.text = "Todo:";
		lightSwitchTaskText.text = "- Hit the lights";
		controlPanelTaskText.text = "- Activate all control panels";
		nukeTaskText.text = "- Load all nukes into engine";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool GetControlPanelTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void TriggerControlPanelTaskComplete() {
		controlPanelTaskComplete = true;
		controlPanelTaskText.supportRichText = true;
		controlPanelTaskText.text = "<color=#292929ff>- Activate all control panels</color>";
		CheckVictoryCondition ();
	}

	public bool GetNukeTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void TriggerNukeTaskComplete() {
		nukeTaskComplete = true;
		nukeTaskText.supportRichText = true;
		nukeTaskText.text = "<color=#292929ff>- Load all nukes into engine</color>";
		CheckVictoryCondition ();
	}

	public bool GetLightSwitchTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void TriggerLightSwitchTaskComplete() {
		lightSwitchTaskComplete = true;
		lightSwitchTaskText.supportRichText = true;
		lightSwitchTaskText.text = "<color=#292929ff>- Hit the lights</color>";
		CheckVictoryCondition ();
	}

	public void CheckVictoryCondition() {
		
		if (lightSwitchTaskComplete && controlPanelTaskComplete && nukeTaskComplete) {
			//Change scene or something?
		}
	}
}
