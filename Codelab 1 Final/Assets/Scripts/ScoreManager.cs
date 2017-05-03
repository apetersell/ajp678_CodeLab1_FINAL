using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	
	public KeyCode restart;

	void Start () {
	}
		
	
	// Update is called once per frame
	void Update () {

			if (Input.GetKeyDown (restart)) 
			{
				SceneManager.LoadScene ("Editor Scene");
			}
	}
}
