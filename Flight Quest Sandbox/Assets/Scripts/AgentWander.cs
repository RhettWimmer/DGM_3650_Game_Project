﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random=UnityEngine.Random;

[RequireComponent((typeof(NavMeshAgent)))]
public class AgentWander : MonoBehaviour
{
 
	public float wanderRadius;
	public float wanderTimer;
 
	private Transform target;
	private NavMeshAgent agent;
	private float timer;
 

	void OnEnable () {
		agent = GetComponent<NavMeshAgent> ();
		timer = wanderTimer;
	}
 
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
 
		if (timer >= wanderTimer) {
			Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
			agent.SetDestination(newPos);
			timer = 0;
		}
	}
 
	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
		Vector3 randDirection = Random.insideUnitSphere * dist;
 
		randDirection += origin;
 
		NavMeshHit navHit;
 
		NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
 
		return navHit.position;
	}
}
