using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public float Velocity = 1f;

	void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Velocity * Time.deltaTime * h, 0, Velocity * Time.deltaTime * v);
	}
}
