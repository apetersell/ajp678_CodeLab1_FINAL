using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class PlayerLoader : MonoBehaviour {

	PlayerData PD; 
	JSONArray jArray;
	// Use this for initialization
	void Start () 
	{
		jArray = UtilScript.ReadJSONFromFile(Application.dataPath, "PlayerData.txt") as JSONArray; 
		//		LD = new LevelData (jArray [0]);
		//		Debug.Log(LD.owner);


		for (int i = 0; i < jArray.Count; i++) {

			PD= new PlayerData (jArray [i]);  
			if (PD.playerNum == 1) 
			{
				GameObject playerPost = GameObject.Instantiate (Resources.Load ("Prefabs/GalPosMarker")) as GameObject;
				playerPost.transform.position = PD.playerPos;
			}
			if (PD.playerNum == 2) 
			{
				GameObject playerPost = GameObject.Instantiate (Resources.Load ("Prefabs/GuyPosMarker")) as GameObject;
				playerPost.transform.position = PD.playerPos;
			}

		}

	}

	// Update is called once per frame
	void Update () {
	}
}
