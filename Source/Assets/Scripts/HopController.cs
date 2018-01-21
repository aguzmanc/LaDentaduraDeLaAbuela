using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopController : MonoBehaviour {

	public int ZHopDistance = 200;
	public int JumpHeight = 600;

	[Range(0.1f, 1)]
	public float reloadSpeed = 0.5f;
	public RectTransform slider;
	float _hopCooldown = 100;

	void Update () {
		if (_hopCooldown < 100) {
			_hopCooldown += reloadSpeed;
			float _sliderValue = _hopCooldown * 1.5f;
			if (_sliderValue > 150)
				_sliderValue = 150;
			slider.GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, _sliderValue);
		} else if (_hopCooldown >= 100) {
			if (Input.GetKeyUp ("z")) {
				this.gameObject.GetComponent<Rigidbody> ().AddRelativeForce (0, JumpHeight, ZHopDistance);
				_hopCooldown = 0;
			}
		}
	}
}
