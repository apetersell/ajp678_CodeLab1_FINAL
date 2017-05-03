using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class PlayerSaver : MonoBehaviour {

	public PlayerData[] playDat; 

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
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player"); 
		playDat = new PlayerData[players.Length];
		for (int i = 0; i < players.Length; i++) 
		{
			int num = players [i].GetComponent<PlayerMovement>().playerNum;
			Vector3 pos = players [i].gameObject.transform.position; 
			Debug.Log (pos);
			playDat [i] = new PlayerData (pos, num);
			Debug.Log (playDat);
		}

		saveLevelToJSONArray ();
	}

	void saveLevelToJSONArray ()
	{
		JSONArray jArray = new JSONArray (); 
		for (int i = 0; i < playDat.Length; i++) 
		{ 
			jArray.Add (playDat [i].ToJSON());
		}

		UtilScript.WriteJSONtoFile(Application.dataPath, "PlayerData.txt", jArray); 
	}

}
