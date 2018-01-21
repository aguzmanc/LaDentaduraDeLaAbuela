using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRaycast : MonoBehaviour {
	public float MaxDistance;
	public float Duration = 0.2f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, Duration);
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		Ray bulletRay = new Ray (transform.position, transform.forward);
		Debug.DrawRay (bulletRay.origin, bulletRay.direction * MaxDistance, Color.red);
		Physics.Raycast (bulletRay, MaxDistance);
	}
}
