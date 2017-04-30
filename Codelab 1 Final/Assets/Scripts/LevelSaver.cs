using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LevelSaver : MonoBehaviour {
	
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

	public static void save ()
	{
		Buildables[] levelStuff = FindObjectsOfType (typeof (Buildables)) as Buildables[];
		for (int i = 0; i < levelStuff.Length; i++) {
			Debug.Log (levelStuff [i]);
			int own = levelStuff [i].owner;
			string typ = levelStuff [i].itemName;
			Vector3 pos = levelStuff [i].gameObject.transform.position; 

			LevelData ld = new LevelData (pos, own, typ); 
			ld.Save ("LevelData.txt");
		}
	}
}
