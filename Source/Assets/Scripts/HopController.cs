using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopController : MonoBehaviour {

	public int ZHopDistance = 0;

	void OnTriggerEnter (Collider col) {
		this.gameObject.SetActive (false);
		col.gameObject.transform.Translate (0, 0, ZHopDistance, Space.World);
	}

	void Update () {
		this.transform.Rotate (0, 1, 0);
	}
}
