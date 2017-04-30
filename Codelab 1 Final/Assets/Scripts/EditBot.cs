using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditBot : MonoBehaviour {

	public int playerNum;
	public float moveSpeed; 
	public GameObject [] buildables = new GameObject[6];  
	public int buildPower = 100;
	public int buildNumber; 
	public List<GameObject> visibleTargets = new List<GameObject>();
	public Buildables b;
	public GameObject otherPlayer;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		if (playerNum == 1) 
		{
			otherPlayer = GameObject.Find ("GuyBot");
		}
		if (playerNum == 2) 
		{
			otherPlayer = GameObject.Find ("GalBot");
		}
		
	}
	
	// Update is called once per frame
	void Update () {


		move ();
		edit ();

		b = buildables [buildNumber].GetComponent<Buildables> (); 
		
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
			if (b.cost <= buildPower) 
			{
				createObject (buildNumber);
			}
		} 

		if (Input.GetButtonDown ("Attack_P" + playerNum)) 
		{
			removeObjects ();
		}

	}

	void OnTriggerEnter2D (Collider2D touched)
	{
		if (touched.GetComponent<Buildables>() != null) 
		{
			Debug.Log ("Touched " + touched.name);
			visibleTargets.Add (touched.gameObject);
		}
	}

	void OnTriggerExit2D (Collider2D touched)
	{
		if (touched.GetComponent<Buildables> () != null)
			visibleTargets.Remove (touched.gameObject);
	}

	void createObject (int num)
	{
		GameObject placedObject = Instantiate (buildables [num], transform.position, Quaternion.identity);
		Buildables thisB = placedObject.GetComponent<Buildables> ();
		thisB.owner = playerNum;  
		thisB.setup ();
		thisB.colorChange ();
		buildPower = buildPower - b.cost; 
	}

	void removeObjects ()
	{
		for (int i = 0; i < visibleTargets.Count; i++) 
		{ 
			Buildables b = visibleTargets [i].GetComponent<Buildables> ();
			if (b.owner == playerNum) 
			{
				buildPower = buildPower + b.cost;
			}
			if (b.owner != playerNum) 
			{
				otherPlayer.GetComponent<EditBot> ().buildPower = otherPlayer.GetComponent<EditBot> ().buildPower + b.cost;
			}
				Destroy (visibleTargets [i].gameObject);
			
		}

		visibleTargets.Clear ();

	}



}
