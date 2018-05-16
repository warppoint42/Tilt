using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		thrust = 20f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Goal") 
		{
			rb.AddForce (transform.up * thrust, ForceMode.Impulse);
			//rb.useGravity = false;
		}
	}
}
