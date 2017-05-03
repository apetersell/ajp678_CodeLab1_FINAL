using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPlatforms : Buildables{

	GameObject player; 

	public override void setup ()
	{
		GameObject fightRecognizer = GameObject.Find ("Player Guy");
		if (owner == 1) 
		{
			if (fightRecognizer != null) {
				player = GameObject.Find ("Player Gal");
			} 
			else 
			{
				player = GameObject.Find ("GalBot");
			}
		}

		if (owner == 2) 
		{
			if (fightRecognizer != null) {
				player = GameObject.Find ("Player Guy");
			} 
			else 
			{
				player = GameObject.Find ("GuyBot");
			}
		transform.eulerAngles = new Vector3 (0, 0, 180);  

		}
	
		SpriteRenderer[] sr = GetComponentsInChildren<SpriteRenderer> (); 
		SpriteRenderer psr = player.GetComponent<SpriteRenderer> ();  
		for (int i = 0; i < sr.Length; i++) 
		{
			sr [i].color = psr.color;
		}
	}
}
