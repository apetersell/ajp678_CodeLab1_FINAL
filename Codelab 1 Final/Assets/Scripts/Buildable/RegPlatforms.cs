using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegPlatforms : Buildables{

	public override void setup ()
	{
//		Debug.Log ("Player " + owner + " made a Regular Platform!");
		if (owner == 2) 
		{
			transform.eulerAngles = new Vector3 (0, 0, 90);  

		}
	}
}
