using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRaycast : MonoBehaviour {
	public float MaxDistance;
	public float Duration = 0.2f;
	public GameObject Particles;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, Duration);
		transform.parent = null;
		Ray bulletRay = new Ray (transform.position, transform.forward);
		Debug.DrawRay (bulletRay.origin, bulletRay.direction * MaxDistance, Color.red);
		RaycastHit hitInfo;
		if (Physics.Raycast (bulletRay, out hitInfo, MaxDistance)) {
			GameObject hitParticles = Instantiate (Particles);
			hitParticles.transform.position = hitInfo.point;
			hitParticles.transform.eulerAngles = hitInfo.normal;
			Destroy (hitParticles, Duration);
		}
	}
	
	// Update is called once per frame
	/*void Update () {
		Ray bulletRay = new Ray (transform.position, transform.forward);
		Debug.DrawRay (bulletRay.origin, bulletRay.direction * MaxDistance, Color.red);
		RaycastHit hitInfo;
		if (Physics.Raycast (bulletRay, out hitInfo, MaxDistance)) {
			GameObject hitParticles = Instantiate (Particles);
			hitParticles.transform.position = hitInfo.point;
			hitParticles.transform.eulerAngles = hitInfo.normal;
		}
	}*/
}
