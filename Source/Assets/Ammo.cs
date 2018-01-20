using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {
	public float Speed = 0.01f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10);
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, Speed);
	}
}
