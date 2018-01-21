using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleachAction : MonoBehaviour {

	// drag an enemy GameObject ??

	void OnTriggerEnter (Collider col) {
		//enemysgameobject.speed *=
		//set timeout
		Destroy (gameObject);
	}
}
