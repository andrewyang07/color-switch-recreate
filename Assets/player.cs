using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float jumpForce = 10f;
    public Rigidbody2D circle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            circle.velocity = Vector2.up * jumpForce;
        }
	}
}
