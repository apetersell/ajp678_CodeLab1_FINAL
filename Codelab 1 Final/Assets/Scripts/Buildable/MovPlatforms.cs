using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlatforms : Buildables {

	public override void setup()
	{
		if (owner == 2) 
		{
			GetComponent<MovingPlatform> ().vertical = true;

		}
	}
}
