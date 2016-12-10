using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeController : GenericPickupableObject {

	private NukeTaskController nukeTaskController;

	// Use this for initialization
	void Start () {
		nukeTaskController = GameObject.FindObjectOfType<NukeTaskController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Destroy () {
		base.Destroy ();
		nukeTaskController.decrementNumberOfNukes ();
	}
}
