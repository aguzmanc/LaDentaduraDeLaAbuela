using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {
	public float Speed = 0.01f;
	public float Duration = 0.2f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, Duration);
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, Speed);
	}

	void setRandomRotation() {
	}
}
