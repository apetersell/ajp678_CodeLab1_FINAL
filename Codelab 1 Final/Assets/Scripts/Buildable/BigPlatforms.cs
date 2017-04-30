using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPlatforms : Buildables{

	GameObject player; 

	public override void setup ()
	{
		if (owner == 1) 
		{
			player = GameObject.Find ("GalBot");
		}

		if (owner == 2) 
		{
			player = GameObject.Find ("GuyBot");
			transform.eulerAngles = new Vector3 (0, 0, 180);  
		}
	
		SpriteRenderer[] sr = GetComponentsInChildren<SpriteRenderer> (); 
		SpriteRenderer psr = player.GetComponent<SpriteRenderer> ();  
		for (int i = 0; i < sr.Length; i++) 
		{
			sr [i].color = psr.color;
		}

		Debug.Log ("Player " + owner + " made a Big Platform!");
	}
}
