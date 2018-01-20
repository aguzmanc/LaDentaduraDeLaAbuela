using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleachController : MonoBehaviour {

	void Start () {
		
	}

	void OnTriggerEnter (Collider col) {
		Time.timeScale /= 2;
		this.gameObject.SetActive (false);
	}

	void Update () {
		this.transform.Rotate (0, 1, 0);
	}
}
