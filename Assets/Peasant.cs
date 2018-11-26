using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peasant : MonoBehaviour {
	public float speed = 1f;
	public GameObject wife;
	public float pigSpeedMultiplier=3f;
	public static bool onPig = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a"))
			transform.position += Vector3.left * speed * Time.deltaTime;
		if (Input.GetKey("d"))
			transform.position += Vector3.right * speed * Time.deltaTime;
		if (Input.GetKey("w"))
			transform.position += Vector3.up * speed * Time.deltaTime;
		if (Input.GetKey("s"))
			transform.position += Vector3.down * speed * Time.deltaTime;
		if (onPig == true)
			speed = pigSpeedMultiplier;
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.tag == "wife"&&Wife.barVisited)
			Destroy (gameObject);
		if (coll.collider.tag == "home")
			Destroy (wife);
		
	}
}
