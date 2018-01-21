using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tremble : MonoBehaviour {
	[Range(0, 3)]
	public float Velocity = 1;
	[Range(0, 5)]
	public float Range = 5;

	Vector3 _originPosition;
	Vector3 _originRotation;

	float _x = 0;
	float _noise = 0;

	void Start () {
		_originPosition = transform.position;
		_originRotation = transform.eulerAngles;
	}
	
	void Update () {
		_x = _x > 999999 ? 0 : _x + Velocity;
		float newNoise = Mathf.PerlinNoise (_x, 0) * Range * 2 - Range;
		transform.Rotate (-_noise + newNoise, -_noise + newNoise, 0);
		_noise = newNoise;
	}
}
