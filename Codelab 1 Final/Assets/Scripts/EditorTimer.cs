using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EditorTimer : MonoBehaviour {

	public float maxTime;
	public float currentTime;
	Text t;


	// Use this for initialization
	void Start () {
		currentTime = maxTime;
		t = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		currentTime = currentTime - Time.deltaTime;
		t.text = Mathf.RoundToInt (currentTime).ToString();
		
	}
}
