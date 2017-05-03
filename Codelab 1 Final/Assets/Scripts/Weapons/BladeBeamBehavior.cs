using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeBeamBehavior : MonoBehaviour {

	public float beamTimer; 
	public float beamLimit; 
	public int beamDamage;
	public int owner;
	public bool finished;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		beamTimer++;
		if (beamTimer >= beamLimit) {
			finished = true;
		}

		if (finished) 
		{
			BeamPool.addToPool (gameObject);
		}
		
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.tag == "Floor")
		{
			finished = true;
		}

	}

	public void reset ()
	{
		finished = false;
		beamTimer = 0;
	}

}
