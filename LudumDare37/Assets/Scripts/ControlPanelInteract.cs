﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanelInteract : MonoBehaviour, IInteractable {

	private Light myLight;
	public float maxIntensity = 1f;
	public float minIntensity = 0f;
	public float pulseSpeed = 1f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
	private float targetIntensity = 0f;
	private float currentIntensity;    


	void Start(){
		myLight = transform.FindChild("PointLight").GetComponent<Light>();
	}    
	void Update(){
		currentIntensity = Mathf.MoveTowards(myLight.intensity,targetIntensity, Time.deltaTime*pulseSpeed);
		if(currentIntensity >= maxIntensity){
			currentIntensity = maxIntensity;
			targetIntensity = minIntensity;
		}else if(currentIntensity <= minIntensity){
			currentIntensity = minIntensity;
			targetIntensity = maxIntensity;
		}
		myLight.intensity = currentIntensity;
	}

	public void Interact() {
		Debug.Log ("Clicking on Control Panel");
		myLight.color = Color.green;
		pulseSpeed = 6f;
	}
}
