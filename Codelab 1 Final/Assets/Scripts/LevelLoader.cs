using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LevelLoader : MonoBehaviour {

	LevelData LD; 
	JSONArray jArray;
	public int galUsedPower = 0;
	public int guyUsedPower = 0;

	// Use this for initialization
	void Start () 
	{
		if (ScoreManager.firstScene == false) {
			jArray = UtilScript.ReadJSONFromFile (Application.dataPath, "LevelData.txt") as JSONArray; 
//		LD = new LevelData (jArray [0]);
//		Debug.Log(LD.owner);


			for (int i = 0; i < jArray.Count; i++) {

				LD = new LevelData (jArray [i]);  
				GameObject stageElement = GameObject.Instantiate (Resources.Load ("Prefabs/" + LD.type)) as GameObject; 
				stageElement.transform.position = LD.position;
				stageElement.GetComponent<Buildables> ().owner = LD.owner;
				stageElement.GetComponent<Buildables> ().setup ();
				stageElement.GetComponent<Buildables> ().colorChange ();
				if (LD.owner == 1) {
					galUsedPower = galUsedPower + stageElement.GetComponent<Buildables> ().cost; 
				}
				if (LD.owner == 2) {
					guyUsedPower = guyUsedPower + stageElement.GetComponent<Buildables> ().cost; 
				}

			}
		}

	}

	// Update is called once per frame
	void Update () {
	}
}
