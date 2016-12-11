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

	public bool getControlPanelTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void triggerControlPanelTaskComplete() {
		controlPanelTaskComplete = true;
		controlPanelTaskText.supportRichText = true;
		controlPanelTaskText.text = "<color=#292929ff>- Activate all control panels</color>";
	}

	public bool getNukeTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void triggerNukeTaskComplete() {
		nukeTaskComplete = true;
		nukeTaskText.supportRichText = true;
		nukeTaskText.text = "<color=#292929ff>- Load all nukes into engine</color>";
	}

	public bool getLightSwitchTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void triggerLightSwitchTaskComplete() {
		lightSwitchTaskComplete = true;
		lightSwitchTaskText.supportRichText = true;
		lightSwitchTaskText.text = "<color=#292929ff>- Hit the lights</color>";
	}
}
