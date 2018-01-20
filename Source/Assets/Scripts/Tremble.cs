using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tremble : MonoBehaviour {
	public float Delay = 0.1f;
	public float PositionIntensity = 0.1f;
	public float RotationIntensity = 1;

	Vector3 _originPosition;
	Vector3 _originRotation;

	// Use this for initialization
	void Start () {
		_originPosition = transform.position;
		_originRotation = transform.eulerAngles;
		StartCoroutine (TremblePositionAndRotation ());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator TremblePositionAndRotation() {
		while (true) {
			//_originPosition = transform.position;
			//_originRotation = transform.eulerAngles;
			yield return new WaitForSeconds(Delay);
			transform.position = RandomPosition (transform.position);
			transform.eulerAngles = RandomRotation (transform.eulerAngles);
		}
	}

	Vector3 RandomPosition(Vector3 position) {
		return position + Random.insideUnitSphere * PositionIntensity;
	}

	Vector3 RandomRotation(Vector3 rotation) {
		return rotation + Random.insideUnitSphere * RotationIntensity;
	}
}
