using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LevelSaver : MonoBehaviour {

	public LevelData[] placedObjects;
	public GameObject[] players;  

	// Use this for initialization
	void Start () { 
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			save();
		}

	}

	public void save ()
	{
		Debug.Log ("Saved!");
		Buildables[] levelStuff = FindObjectsOfType (typeof (Buildables)) as Buildables[];
		placedObjects = new LevelData[levelStuff.Length];
		for (int i = 0; i < levelStuff.Length; i++) 
		{
			int own = levelStuff [i].owner;
			string typ = levelStuff [i].itemName;
			Vector3 pos = levelStuff [i].gameObject.transform.position; 
			placedObjects [i] = new LevelData (pos, own, typ);
		}
		
		saveLevelToJSONArray ();
	}

	void saveLevelToJSONArray ()
	{
		JSONArray jArray = new JSONArray (); 
		for (int i = 0; i < placedObjects.Length; i++) 
		{ 
			jArray.Add (placedObjects [i].ToJSON());
		}

		UtilScript.WriteJSONtoFile(Application.dataPath, "LevelData.txt", jArray); 
	}
}
