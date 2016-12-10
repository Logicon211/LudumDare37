using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickupable {
	void Pickup (GameObject parent);
	void Release (GameObject parent);
}
