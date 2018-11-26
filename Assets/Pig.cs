using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {
	public GameObject player;
	bool playerOnPig = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerOnPig == true)
			transform.position = player.transform.position;
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		//if (coll.collider.tag == "peasant") 
		//{
			playerOnPig = true;
			Peasant.onPig = true;
		//}
	}
}
