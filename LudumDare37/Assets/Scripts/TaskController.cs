using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskController : MonoBehaviour {

	private bool lightSwitchTaskComplete = false;
	private bool controlPanelTaskComplete = false;
	private bool nukeTaskComplete = false;
	private bool phoneTaskComplete = false;
	private bool repairableObjectTaskComplete = false;

	public Text taskListTitle;
	public Text lightSwitchTaskText;
	public Text controlPanelTaskText;
	public Text nukeTaskText;
	public Text repairableObjectTaskText;
	public Text phoneTaskText;

	public Light endGameLight;

	// Use this for initialization
	void Start () {
		taskListTitle.text = "Todo:";
		lightSwitchTaskText.text = "- Hit the lights";
		controlPanelTaskText.text = "- Activate all control panels";
		nukeTaskText.text = "- Load all nukes into engine";
		repairableObjectTaskText.text = "- Repair all smoking objects";
		phoneTaskText.text = "- Answer the ringing phone";
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

	public bool GetPhoneTaskComplete(){
		return phoneTaskComplete;
	}

	public void TriggerPhoneTaskComplete(){
		phoneTaskComplete = true;
		phoneTaskText.supportRichText = true;
		phoneTaskText.text = "<color=#292929ff>- Answer the ringing phone</color>";
		CheckVictoryCondition ();
		//other shit
	}
	public bool GetRepairableObjectTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void TriggerRepairableObjectTaskComplete() {
		repairableObjectTaskComplete = true;
		repairableObjectTaskText.supportRichText = true;
		repairableObjectTaskText.text = "<color=#292929ff>- Repair all smoking objects</color>";
		CheckVictoryCondition ();
	}

	public void CheckVictoryCondition() {
		
		if (lightSwitchTaskComplete && controlPanelTaskComplete && nukeTaskComplete && phoneTaskComplete && repairableObjectTaskComplete) {

			GameObject thedoor = GameObject.FindWithTag("SF_Door");
			thedoor.GetComponent<Animation>().Play("open");
			endGameLight.enabled = true;
		}

	}
}
