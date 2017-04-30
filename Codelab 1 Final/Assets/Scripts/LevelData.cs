using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LevelData : MonoBehaviour {

	public int owner;
	public string type;
	public Vector3 position;

	private const string POS_X = "xpos"; 
	private const string POS_Y = "ypos";
	private const string POS_Z = "zpos";
	private const string TYPE = "type";
	private const string OWNER = "owner";


	public LevelData(string fileName)
	{
		JSONNode json = UtilScript.ReadJSONFromFile (Application.dataPath, fileName); 

		position = new Vector3 (
			json [POS_X].AsFloat,
			json [POS_Y].AsFloat, 
			json [POS_Z].AsFloat); 
		type = json [TYPE];
		owner = json [OWNER].AsInt; 
	}

	public LevelData(Vector3 position, int owner, string type){
		this.position = position;
		this.owner = owner;
		this.type = type;
	}

	public JSONClass ToJSON(){
		JSONClass json = new JSONClass();

		json[POS_X].AsFloat = position.x;
		json[POS_Y].AsFloat = position.y;
		json[POS_Z].AsFloat = position.z;
		json [TYPE] = type;
		json [OWNER].AsInt = owner;

		return json;
	}

	public void Save(string fileName){
		JSONClass json = ToJSON();
		UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
	}
}
