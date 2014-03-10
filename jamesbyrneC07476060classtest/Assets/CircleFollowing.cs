/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CircleFollowing : MonoBehaviour {
	float mass = 1f;
	float maxSpeed = 5f;
//	Vector3 force = Vector3.forward;
	//public Vector3 velocity = (0,0,5);
	Vector3 velocity = Vector3.zero;
	int currentWaypoint = 1;
	ArrayList waypoints;

	// Use this for initialization
	void Start () 
	{
		velocity = Vector3 (0, 0, 5);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	for (int i = 0; i <1 ; i++) 
		{
			float ChangePosition = 36;

			if (i > ChangePosition )
			{
				velocity = Vector3(Mathf.Sin(i)*10 , 0 , Mathf.Cos(i)*10);
				ChangePosition = ChangePosition + 36;
			}

		}

	
	}
}
*/