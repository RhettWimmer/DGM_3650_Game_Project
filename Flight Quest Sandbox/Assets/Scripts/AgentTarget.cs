using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class AgentTarget : MonoBehaviour
{
    public Transform Destination;
    private NavMeshAgent agent;
	public GameObject stopper;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = Destination.position;
    }
	
	private void OnTriggerEnter(Collider stopper){
		
	}
}

