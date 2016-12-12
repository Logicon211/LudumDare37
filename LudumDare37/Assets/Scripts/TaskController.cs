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

	private GameObject endGameCollider;

	public Text taskListTitle;
	public Text lightSwitchTaskText;
	public Text controlPanelTaskText;
	public Text nukeTaskText;
	public Text repairableObjectTaskText;
	public Text phoneTaskText;

	public Light endGameLight;

	//Audio clips
	public AudioSource KillbaneSpeech;


	AudioClip Phone;
	AudioClip Wrench;
	AudioClip Systems;
	AudioClip TimeToGo;
	AudioClip FixTheShip;
	AudioClip ImOnIt;
	AudioClip Lights;
	AudioClip Engine;

	//AudioClip Phone = Resources.Load("Sounds/ShadowGovernment")as AudioClip;


	//AudioClip clip2 = Resources.Load<AudioClip>("Sounds/cube_up");
	//AudioClip clip3 = Resources.Load("Sounds/cube_onslot") as AudioClip;


	// Use this for initialization
	void Start () {
		taskListTitle.text = "Todo:";
		lightSwitchTaskText.text = "- Hit the lights";
		controlPanelTaskText.text = "- Activate all control panels";
		nukeTaskText.text = "- Load all nukes into engine";
		repairableObjectTaskText.text = "- Repair all smoking objects";
		phoneTaskText.text = "- Answer the ringing phone";
		endGameCollider = transform.FindChild ("ExitDoor").gameObject;
		//Audio files

		Phone = Resources.Load("Sounds/ShadowGovernment")as AudioClip;
		Wrench = Resources.Load("Sounds/ShouldBeFixedNow")as AudioClip;
		Systems = Resources.Load("Sounds/SystemsShouldBeRestartedNow")as AudioClip;
		TimeToGo = Resources.Load("Sounds/TimeToGetOutOfHere")as AudioClip;
		FixTheShip = Resources.Load("Sounds/ThatsBetterNowToFixTheShip")as AudioClip;
		ImOnIt = Resources.Load("Sounds/ImOnItCommanderPresident")as AudioClip;
		Lights = Resources.Load("Sounds/GottaTurnOnTheLights")as AudioClip;
		Engine = Resources.Load("Sounds/EngineShouldHaveEnoughPowerNow")as AudioClip;

		Invoke ("StartingWords", 2f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void StartingWords(){

		KillbaneSpeech.PlayOneShot (Lights);
	}

	public bool GetControlPanelTaskComplete () {
		return controlPanelTaskComplete;
	}
		
	public void TriggerControlPanelTaskComplete() {
		controlPanelTaskComplete = true;
		controlPanelTaskText.supportRichText = true;
		controlPanelTaskText.text = "<color=#292929ff>- Activate all control panels</color>";
		CheckVictoryCondition ();
		KillbaneSpeech.PlayOneShot (Systems);

	}

	public bool GetNukeTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void TriggerNukeTaskComplete() {
		nukeTaskComplete = true;
		nukeTaskText.supportRichText = true;
		nukeTaskText.text = "<color=#292929ff>- Load all nukes into engine</color>";
		CheckVictoryCondition ();
		KillbaneSpeech.PlayOneShot (Engine);
	}

	public bool GetLightSwitchTaskComplete () {
		return controlPanelTaskComplete;
	}

	public void TriggerLightSwitchTaskComplete() {
		lightSwitchTaskComplete = true;
		lightSwitchTaskText.supportRichText = true;
		lightSwitchTaskText.text = "<color=#292929ff>- Hit the lights</color>";
		CheckVictoryCondition ();
		KillbaneSpeech.PlayOneShot (FixTheShip);
	}

	public bool GetPhoneTaskComplete(){
		return phoneTaskComplete;
	}

	public void TriggerPhoneTaskComplete(){
		phoneTaskComplete = true;
		phoneTaskText.supportRichText = true;
		phoneTaskText.text = "<color=#292929ff>- Answer the ringing phone</color>";
		CheckVictoryCondition ();
		KillbaneSpeech.PlayOneShot (ImOnIt);
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
		KillbaneSpeech.PlayOneShot (Wrench);
	}

	public void CheckVictoryCondition() {
		
		if (lightSwitchTaskComplete && controlPanelTaskComplete && nukeTaskComplete && phoneTaskComplete && repairableObjectTaskComplete) {

			GameObject thedoor = GameObject.FindWithTag("SF_Door");
			thedoor.GetComponent<Animation>().Play("open");
			endGameLight.enabled = true;
			endGameCollider.GetComponent<BoxCollider> ().enabled = true;
			KillbaneSpeech.PlayOneShot (TimeToGo);
		}

	}
}
