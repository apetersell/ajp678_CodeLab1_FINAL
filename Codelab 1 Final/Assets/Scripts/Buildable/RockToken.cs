using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockToken : Buildables {

	public override void setup ()
	{
		Debug.Log ("Player " + owner + " made a Big Shot Power Up!");
	}
}
