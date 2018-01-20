using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrayController : MonoBehaviour {

	void Start () {
		
	}

	void OnTriggerEnter (Collider col) {
		this.gameObject.SetActive (false);
	}

	void Update () {
		this.transform.Rotate (0, 1, 0);
	}
}
