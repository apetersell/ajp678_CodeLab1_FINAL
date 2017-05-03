using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamPool : MonoBehaviour {

	public static Queue <GameObject> beamPool = new Queue<GameObject>();


	public static GameObject pullFromPool()
	{
		GameObject beam;

		if(beamPool.Count > 0)
		{
			beam = beamPool.Dequeue(); 
		} 
		else 
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
