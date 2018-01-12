using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform Player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// If a player has passed the position
		// The camera won't move while falling
		if (Player.position.y > transform.position.y) {
			transform.position = new Vector3 (transform.position.x, 
											  Player.position.y,
											  transform.position.z);
		}
	}
}
