using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour 
{
    Transform _player;

    public float Smoothness = 0.2f;

	void Start () 
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
	}


	void Update () 
    {
        transform.position = Vector3.Lerp(transform.position, _player.position, Time.deltaTime * Smoothness);
		
	}
}
