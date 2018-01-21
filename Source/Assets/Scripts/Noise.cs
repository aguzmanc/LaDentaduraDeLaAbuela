using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour {

	public float _x = 0;
	public float Velocidad = 0.1f;
	public float noise;

	public Light fire;

	void Start () {
		_x = Random.Range (0f, 10f);
		Velocidad = Random.Range (0, 0.1f);	
	}

	void Update () {
		_x += Velocidad;
		noise = Mathf.PerlinNoise (_x,0);

		fire.intensity = noise;
	}
}
