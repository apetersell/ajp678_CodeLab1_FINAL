using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {

	public Text galHealth;
	public Text guyHealth;
	Text galT;
	Text guyT;

	// Use this for initialization
	void Start () {

		galT = galHealth.GetComponent<Text> ();
		guyT = guyHealth.GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		galT.text = ScoreManager.playerGalHealth.ToString ();
		guyT.text = ScoreManager.playerGuyHealth.ToString ();
	}
}
