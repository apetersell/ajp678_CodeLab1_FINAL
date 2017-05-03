using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterFirstScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (ScoreManager.firstScene == false) 
		{
			Destroy (this.gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
