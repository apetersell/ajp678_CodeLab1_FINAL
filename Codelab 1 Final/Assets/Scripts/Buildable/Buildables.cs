using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buildables : MonoBehaviour {

	// Use this for initialization
	public int cost; 
	public int owner;
	public string itemName;

	void Start ()
	{
		if (transform.position.y > 9.3f) 
		{
			transform.position = new Vector2 (transform.position.x, 9.3f);
		}

		if (transform.position.y < -14.8f) 
		{
			transform.position = new Vector2 (transform.position.x, -14.8f);
		}

		if (transform.position.x > 11.8f) 
		{
			transform.position = new Vector2 (11.8f, transform.position.y);
		}

		if(transform.position.x < -11.2f)
		{
			transform.position = new Vector2 (-11.2f, transform.position.y); 
		}
	}

	public void colorChange () 
	{
		GameObject fightRecognizer = GameObject.Find ("Fight UI");
		if (fightRecognizer != null) 
		{
			if (owner == 1) {
				GameObject player = GameObject.Find ("Player Gal");
				SpriteRenderer sr = player.GetComponent<SpriteRenderer> ();
				GetComponent<SpriteRenderer> ().color = sr.color;
			}
			if (owner == 2) {
				GameObject player = GameObject.Find ("Player Guy");
				SpriteRenderer sr = player.GetComponent<SpriteRenderer> ();
				GetComponent<SpriteRenderer> ().color = sr.color;
			}
		} 
		else 
		{
			if (owner == 1) {
				GameObject player = GameObject.Find ("GalBot");
				SpriteRenderer sr = player.GetComponent<SpriteRenderer> ();
				GetComponent<SpriteRenderer> ().color = sr.color;
			}
			if (owner == 2) {
				GameObject player = GameObject.Find ("GuyBot");
				SpriteRenderer sr = player.GetComponent<SpriteRenderer> ();
				GetComponent<SpriteRenderer> ().color = sr.color;
			}
		}

	}

	public abstract void setup ();

}
