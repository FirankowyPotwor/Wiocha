using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wife : MonoBehaviour {

	public float speed = 1f;
	public static bool barVisited = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left"))
			transform.position += Vector3.left * speed * Time.deltaTime;
		if (Input.GetKey("right"))
			transform.position += Vector3.right * speed * Time.deltaTime;
		if (Input.GetKey("up"))
			transform.position += Vector3.up * speed * Time.deltaTime;
		if (Input.GetKey("down"))
			transform.position += Vector3.down * speed * Time.deltaTime;
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.tag == "bar")
			barVisited = true;
	}
}
