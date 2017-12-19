using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlaceBuilder : MonoBehaviour {

    public GameObject builderPrefab;
    private NavMeshSurface surface;

	// Use this for initialization
	void Start () {
        surface = GetComponent<NavMeshSurface>();

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject go = GameObject.Instantiate(builderPrefab, hit.point, Quaternion.identity);
                go.transform.parent = transform;
                surface.BuildNavMesh();
            }
        }
	}
}
