using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleachController : MonoBehaviour {

	public float DropDistance = 1.5f;
	public Transform Bleach;

	[Range(0.1f, 1)]
	public float reloadSpeed = 0.5f;
	public RectTransform slider;
	float _bleachCooldown = 100;

	void Update () {
		if (_bleachCooldown < 100) {
			_bleachCooldown += reloadSpeed;
			float _sliderValue = _bleachCooldown * 1.5f;
			if (_sliderValue > 150)
				_sliderValue = 150;
			slider.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, _sliderValue);
		} else if (_bleachCooldown >= 100) {
			if (Input.GetKeyUp ("x")) {
				Instantiate(Bleach, transform.position + (transform.forward*DropDistance) - (transform.up*0.5f), transform.rotation);
				_bleachCooldown = 0;
			}
		}
	}
}
