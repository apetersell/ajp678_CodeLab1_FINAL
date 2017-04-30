using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditBot : MonoBehaviour {

	public float playerNum;
	public float moveSpeed; 
	public GameObject [] buildables = new GameObject[6];  
	public int buildPower = 100;
	public int buildNumber; 
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		move ();
		edit ();
		
	}

	void move () {

		Vector2 direction = new Vector2 (Input.GetAxis ("LeftStick_P" + playerNum), Input.GetAxis ("LeftStickY_P" + playerNum));

		rb.velocity = direction * moveSpeed;

	}

	void edit () {

		if (Input.GetButtonDown ("ShiftUp_P" + playerNum)) 
		{
			buildNumber++;
		}

		if (Input.GetButtonDown ("ShiftDown_P" + playerNum)) 
		{
			buildNumber--;
		}

		if (buildNumber > (buildables.Length -1)) 
		{
			buildNumber = 0;
		}

		if (buildNumber < 0) 
		{
			buildNumber = buildables.Length -1;
		}

		if (Input.GetButtonDown ("Jump_P" + playerNum)) 
		{
			Instantiate (buildables [buildNumber], transform.position, Quaternion.identity); 
		} 

	}


}
