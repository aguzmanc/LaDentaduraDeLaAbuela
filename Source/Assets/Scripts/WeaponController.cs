using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
	public float RotationSpeed = 2;
	public GameObject Bullet;
	public Transform SpawnPoint;
	public float ReloadTimePerBullet = 1;
	public int MaxAmmo = 2;
	public int BulletsPerShot = 10;
	public float AccuracyError = 5;
	//public WeaponCooldownUI CooldownUI;
	public WeaponUI WeaponUI;

	int _ammoCount;
	bool _isReloading;

	// Use this for initialization
	void Start () {
		_ammoCount = MaxAmmo;
		_isReloading = false;
		for (int i = 0; i < MaxAmmo; i++) {
			WeaponUI.AddBullet ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		float vRotation = Input.GetAxis ("Mouse Y");
		transform.Rotate (RotationSpeed * -vRotation, 0, 0);

		if (Input.GetMouseButtonDown (0)) {
			Fire ();
		}
		if (Input.GetMouseButtonDown (1)) {
			StartCoroutine (Reload());
		}
	}

	void Fire() {
		if (_ammoCount > 0 && !_isReloading) {
			for (int i = 0; i < BulletsPerShot; i++) {
				GameObject newBullet = Instantiate (Bullet, SpawnPoint);
				newBullet.transform.Rotate (Random.value * AccuracyError, Random.value * AccuracyError, 0);
			}
			WeaponUI.RemoveBullet ();
			_ammoCount--;
			if (_ammoCount <= 0) {
				StartCoroutine (Reload());
			}
		}
	}

	IEnumerator Reload () {
		if (!_isReloading) {
			_isReloading = true;
			//CooldownUI.DisplayCooldown (ReloadTime);
			while (_ammoCount < MaxAmmo) {
				yield return new WaitForSeconds (ReloadTimePerBullet);
				WeaponUI.AddBullet ();
				_ammoCount++;
			}
			_isReloading = false;
		}
	}
}
