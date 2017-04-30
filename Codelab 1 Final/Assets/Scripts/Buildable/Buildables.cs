using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buildables : MonoBehaviour {

	// Use this for initialization
	public enum type {
		PLATFORMH, PLATFORMV, MOVINGPLATFORMH, MOVINGPLATFORMV, BIGPLATFORM, ROCKTOKEN, PAPERTOKEN, SCISSORSTOKEN

	}
	public int cost; 

	void Start () {

		setup ();
	}

	public abstract void setup (); 

}
