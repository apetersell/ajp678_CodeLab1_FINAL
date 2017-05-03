using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenSpawner : MonoBehaviour {

	public GameObject token;
	public float timeUntilSpawn;
	public float maxX;
	public float minX;
	public float maxY;
	public float minY;



	// Use this for initialization
	void Start () {

		timeUntilSpawn = Random.Range (5, 10);
	}
	
	// Update is called once per frame
	void Update () {

		timeUntilSpawn = timeUntilSpawn - Time.deltaTime;
		if (timeUntilSpawn <= 0) 
		{
			token.gameObject.SetActive (true);
			token.transform.position = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
			timeUntilSpawn = Random.Range (5, 10);
		}

		
	}
}
