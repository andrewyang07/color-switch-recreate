using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	public float rotationSpeed = 100f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 0f, rotationSpeed * Time.deltaTime);
	}
}
