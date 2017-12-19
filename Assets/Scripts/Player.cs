using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {

    private NavMeshAgent agent;
    //public Transform target;

    public float roate = 7;
    public float speed = 5;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        //agent.destination = target.position;
        agent.updatePosition = false;
        agent.updateRotation = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.nextPosition = transform.position;
                agent.SetDestination(hit.point);
            }
        }

        Move();
	}

    private void Move()
    {
        if (agent.remainingDistance < 0.5f) return;
        agent.nextPosition = transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(agent.desiredVelocity), roate * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
