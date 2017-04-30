using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EditorUISDisplay : MonoBehaviour {

	public int owner; 
	EditBot eb;
	public GameObject buildPower;
	public GameObject itemName;
	public GameObject cost;
	public GameObject player;
	Text bpt;
	Text nt;
	Text ct;
	public GameObject[] tempList = new GameObject[0];

	// Use this for initialization
	void Start () {

		if (owner == 1) 
		{
			buildPower = GameObject.Find ("GalBuildPower");
			itemName = GameObject.Find ("GalItemName");
			cost = GameObject.Find ("GalCost");
			player = GameObject.Find ("GalBot");
		}

		if (owner == 2) 
		{
			buildPower = GameObject.Find ("GuyBuildPower");
			itemName = GameObject.Find ("GuyItemName");
			cost = GameObject.Find ("GuyCost");
			player = GameObject.Find ("GuyBot");
		}

		bpt = buildPower.GetComponent<Text> ();
		nt = itemName.GetComponent<Text> ();
		ct = cost.GetComponent<Text> ();
		eb = player.GetComponent<EditBot> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		bpt.text = eb.buildPower.ToString ();
		nt.text = eb.selectedItemName;
		ct.text = eb.selectedItemCost;
		
	}
}
