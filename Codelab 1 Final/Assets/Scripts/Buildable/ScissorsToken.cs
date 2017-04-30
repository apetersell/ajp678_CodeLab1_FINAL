using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsToken : Buildables {

	public override void setup ()
	{
		Debug.Log ("Player " + owner + " made a Spread Shot Power Up!");
	}
}
