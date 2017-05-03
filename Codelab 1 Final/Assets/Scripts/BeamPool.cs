using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamPool : MonoBehaviour {

	public static Queue <GameObject> beamPool = new Queue<GameObject>();


	public static GameObject pullFromPool(string beamColor)
	{
		GameObject beam;
		int howManyBeamsWeNeed;

		if (beamColor == "Red") 
		{
			howManyBeamsWeNeed = 4;
		} 
		else 
		{
			howManyBeamsWeNeed = 0;
		}


		if (beamPool.Count > howManyBeamsWeNeed) 
		{
			beam = beamPool.Dequeue ();
		}

		{
			beam = Instantiate(Resources.Load("Prefabs/BladeBeam")) as GameObject;
		}

		beam.SetActive (true);
		beam.GetComponent<BladeBeamBehavior> ().reset ();
		return beam;

	}

	public static void addToPool(GameObject beam)
	{
		beam.SetActive (false);
		beamPool.Enqueue (beam);
	}
}
