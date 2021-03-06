﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class PlayerData : MonoBehaviour {

	public int playerNum;
	public Vector3 playerPos;
	public bool isPosMarker;

	private const string PLAYER_NUM = "playernum"; 
	private const string POS_MARKER = "posmarker";
	private const string POS_X = "xpos"; 
	private const string POS_Y = "ypos";
	private const string POS_Z = "zpos"; 


	public PlayerData(string fileName)
	{
		JSONNode json = UtilScript.ReadJSONFromFile (Application.dataPath, fileName); 

		playerPos = new Vector3 (
			json [POS_X].AsFloat,
			json [POS_Y].AsFloat, 
			json [POS_Z].AsFloat); 
		playerNum = json [PLAYER_NUM].AsInt;
		isPosMarker = json [POS_MARKER].AsBool;
	}

	public PlayerData(JSONNode json)
	{

		playerPos = new Vector3 ( 
			json [POS_X].AsFloat,
			json [POS_Y].AsFloat,
			json [POS_Z].AsFloat); 
		playerNum = json [PLAYER_NUM].AsInt; 
		isPosMarker = json [POS_MARKER].AsBool;
	}

	public PlayerData(Vector3 position, int playNum, bool posMark){
		this.playerPos = position; 
		this.playerNum = playNum; 
		this.isPosMarker = posMark;
	}

	public JSONClass ToJSON(){
		JSONClass json = new JSONClass();

		json[POS_X].AsFloat = playerPos.x; 
		json[POS_Y].AsFloat = playerPos.y; 
		json[POS_Z].AsFloat = playerPos.z; 
		json [PLAYER_NUM].AsInt = playerNum; 
		json [POS_MARKER].AsBool = isPosMarker;

		return json;
	}

	public void Save(string fileName){
		JSONNode json = ToJSON();
		UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
	}

}
