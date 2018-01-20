using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
	public Transform target;
	Vector3 _distance;

	// Use this for initialization
	void Start () {
		_distance = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position + _distance;
		//transform.eulerAngles = new Vector3(transform.eulerAngles.x, target.rotation
		//if (transform.eulerAngles.y != target.eulerAngles.y) {
		//}
	}
}
