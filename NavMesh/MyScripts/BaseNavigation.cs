using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseNavigation : MonoBehaviour {

    public Transform aim;
    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {

        if (agent && aim)
        {
            agent.SetDestination(aim.transform.position);
        }

	}
}
