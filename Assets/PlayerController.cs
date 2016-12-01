using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	NavMeshAgent agent; 
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit result;
			if (Physics.Raycast (ray, out result, 100)) {
				agent.SetDestination (result.point);
			}
		}
	}
}
