﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {

    private NavMeshAgent agent;
    public Transform target;


	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}