using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LevelLoader : MonoBehaviour {

	LevelData LD; 
	JSONArray jArray;
	GameObject stageElement;

	// Use this for initialization
	void Start () 
	{

		jArray = UtilScript.ReadJSONFromFile(Application.dataPath, "LevelData.txt") as JSONArray;
		LD = new LevelData (jArray [0]);

//		for (int i = 0; i < jArray.Count; i++)  
//		{
//
//			LD = new LevelData (jArray[i]);  
//			if (LD.type == "Platform") 
//			{
//				stageElement = GameObject.Instantiate(Resources.Load("Prefabs/Platform")) as GameObject;   
//			}
//
//			if (LD.type == "Moving Platform") 
//			{
//				stageElement = GameObject.Instantiate(Resources.Load("Prefabs/Moving Platform")) as GameObject;   
//			}
//
//			if (LD.type == "Big Platform") 
//			{
//				stageElement = GameObject.Instantiate(Resources.Load("Prefabs/BigPlatform")) as GameObject;   
//			}
//
//			if (LD.type == "Big Shot") 
//			{
//				stageElement = GameObject.Instantiate(Resources.Load("Prefabs/Rock Token")) as GameObject;   
//			}
//		
//			if (LD.type == "Long Shot") 
//			{
//				stageElement = GameObject.Instantiate(Resources.Load("Prefabs/Paper Token")) as GameObject;   
//			}
//
//			if (LD.type == "Spread Shot") 
//			{
//				stageElement = GameObject.Instantiate(Resources.Load("Prefabs/Scissors Token")) as GameObject;   
//			}
//			GameObject stageElement = GameObject.Instantiate(Resources.Load("Prefabs/Platform")) as GameObject;
//			stageElement.transform.position = LD.position;
//			stageElement.GetComponent<Buildables>().owner = LD.owner;
//			stageElement.GetComponent<Buildables> ().setup ();
//			stageElement.GetComponent<Buildables> ().colorChange () ;
//		}

	}

	// Update is called once per frame
	void Update () {
	}
}
