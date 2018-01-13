using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour 
{
    NavMeshAgent _agent;
    Transform _player;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }


	void Update () 
    {
        _agent.SetDestination(_player.position);	
	}
}
