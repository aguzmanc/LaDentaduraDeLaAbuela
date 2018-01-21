using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponCooldownUI : MonoBehaviour {
	float _elapsedTime = 0;
	RectTransform _rt;
	float _cooldownTime = 0;

	// Use this for initialization
	void Start () {
		_rt = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_elapsedTime < _cooldownTime) {
			_elapsedTime += Time.deltaTime;
			_rt.offsetMax = new Vector2 (0, 0);
			_rt.offsetMin = new Vector2 (0, 0);
			_rt.anchorMax = new Vector2 (1 - _elapsedTime / _cooldownTime, 1);
		}
	}

	public void DisplayCooldown(float cooldownTime) {
		_cooldownTime = cooldownTime;
		_elapsedTime = 0;
	}
}
