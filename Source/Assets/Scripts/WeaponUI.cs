using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour {	
	public GameObject BulletUI;
	public float BulletSize = 50;
	List<RectTransform> _bullets = new List<RectTransform>();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddBullet() {
		GameObject newBullet = Instantiate (BulletUI, gameObject.transform);
		RectTransform rt = newBullet.GetComponent<RectTransform> ();
		rt.anchorMin = new Vector2 (0, 0);
		rt.anchorMax = new Vector2 (0, 0);
		if (_bullets.Count == 0) {
			rt.offsetMin = new Vector2 (0, 0);
			rt.offsetMax = new Vector2 (BulletSize, BulletSize);
		} else {
			RectTransform lastBulletRT = _bullets [_bullets.Count - 1].GetComponent<RectTransform> ();
			rt.offsetMin = new Vector2 (lastBulletRT.offsetMax.x, 0);
			rt.offsetMax = new Vector2 (lastBulletRT.offsetMax.x + BulletSize, BulletSize);
		}
		_bullets.Add (rt);
	}

	public void RemoveBullet() {
		if (_bullets.Count > 0) {
			RectTransform lastBullet = _bullets [_bullets.Count - 1];
			Destroy (lastBullet.gameObject);
			_bullets.Remove (lastBullet);
		}
	}
}
