using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTaskController : MonoBehaviour {

	private TaskController parentController;
	private bool taskComplete = false;
	private bool answered = false;

	public AudioClip phone_ringing;
	public AudioClip conversation_clip;
	//This should come from the object in scene
	AudioSource audio;

	// Use this for initialization
	void Start () {
		parentController = GameObject.FindObjectOfType<TaskController> ();
		audio = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {
		//15 seconds after light is turned on, start the phone ringing
		//while (!answered) {
		//}
	}
		
	public void StartRinging(){
		//Start playing audio clip
		audio.clip = phone_ringing;
		audio.PlayDelayed(1.5f);
	}

	public void StartCall(){
		if (!answered) {
			audio.Stop ();
			answered = true;

			Debug.Log ("PHONE: start playing clip");
			//Start audio clip recording for conversation
			audio.PlayOneShot (conversation_clip);

			//while(audiosource.isplaying()){
			//}
			Invoke ("PhoneTaskComplete", 10f);
		}
	}
	private void PhoneTaskComplete(){
			taskComplete = true;
			Debug.Log ("Phone task complete");
			parentController.TriggerPhoneTaskComplete ();
		}
		//}
	//}
		
}