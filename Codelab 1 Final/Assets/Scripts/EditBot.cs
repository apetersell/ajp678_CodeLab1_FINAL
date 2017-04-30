using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditBot : MonoBehaviour {

	public float playerNum;
	public float moveSpeed; 
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		move ();
		
	}

	void move () {

		Vector2 direction = new Vector2 (Input.GetAxis ("LeftStick_P" + playerNum), Input.GetAxis ("LeftStickY_P" + playerNum));

		rb.velocity = direction * moveSpeed;

	}


}
