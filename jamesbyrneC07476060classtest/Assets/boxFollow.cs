using UnityEngine;
using System.Collections;

public class boxFollow : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	Vector3 force = Vector3.zero;
	float maxSpeed = 5f;
	float mass = 1f;
	public Vector3 Target = Vector3.zero;

	// Use this for initialization
	void Start ()
	{
	
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 distance = transform.position - Target;
		Debug.Log (distance);
		velocity = distance / Time.deltaTime;



		transform.position = transform.position + Target + velocity;
	
		Debug.DrawLine (transform.position, Target, Color.blue);
	}

}
