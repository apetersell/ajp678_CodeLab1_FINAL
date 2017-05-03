using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.SceneManagement;

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
			SceneManager.LoadScene ("Editor Scene");
		}

	}

	public void save ()
	{
		GameObject[] players = GameObject.FindGameObjectsWithTag ("Player"); 
		playDat = new PlayerData[players.Length];
		for (int i = 0; i < players.Length; i++) 
		{
			if (players[i].gameObject.name == "Player Guy" || players[i].gameObject.name == "Player Gal") {
				int num = players [i].GetComponent<PlayerMovement> ().playerNum;
				Vector3 pos = players [i].gameObject.transform.position; 
				playDat [i] = new PlayerData (pos, num, false);
			} else {
				int num = players [i].GetComponent<PosMarker> ().playerNum;
				Vector3 pos = players [i].gameObject.transform.position; 
				playDat [i] = new PlayerData (pos, num, true);
			}
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
