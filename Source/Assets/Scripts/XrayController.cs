using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrayController : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject target;

	Color targetColor; 

	[Range(0.1f, 1)]
	public float reloadSpeed = 0.5f;
	public RectTransform slider;
	float _xrayCooldown = 100;

	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		ray.direction = forward;
		Debug.DrawRay(transform.position, forward, Color.green);

		if (Physics.Raycast (ray, out hit)) {
			target = hit.collider.gameObject;
			targetColor = target.GetComponent<Renderer> ().material.color;
		} else
			target = null;

		if (_xrayCooldown < 100) {
			_xrayCooldown += reloadSpeed;
			float _sliderValue = _xrayCooldown * 1.5f;
			if (_sliderValue > 150)
				_sliderValue = 150;
			slider.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, _sliderValue);
		} else if (_xrayCooldown >= 100) {
			if (Input.GetKeyUp ("c")) {
				var newColor = new Color (targetColor.r, targetColor.g, targetColor.b, 0.5f);
				target.GetComponent<Renderer> ().material.color = newColor;

				_xrayCooldown = 0;
			}
		}			
	}
}
