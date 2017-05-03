using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour {

	public static ScoreManager keepIt; 
	public KeyCode restart;
	public bool itsOver = false;
	public static int playerGalHealth = 100;
	public static int playerGuyHealth = 100;
	public int maxHealth = 100;
	public static bool firstScene = true;


	void Start () {
		{
			if (keepIt == null){
				keepIt = this;  
				DontDestroyOnLoad (this);
			}
			else
			{
				Destroy (gameObject);
			}

		}
	}
		

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Debug.Log (playerGalHealth);
			Debug.Log (playerGuyHealth);
		}
		if (Input.GetKeyDown (restart) && itsOver == true) 
		{
			
			itsOver = false;
			UtilScript.WriteStringToFile (Application.dataPath, "LevelData.txt", "");
			UtilScript.WriteStringToFile (Application.dataPath, "PlayerData.txt", "");
			firstScene = true;
			SceneManager.LoadScene ("Editor Scene"); 
		}

		if (playerGalHealth <= 0) 
		{
			SceneManager.LoadScene ("Player Guy Wins");
			itsOver = true;
			playerGalHealth = maxHealth;
			playerGuyHealth = maxHealth;
		}

		if (playerGuyHealth <= 0) 
		{
			SceneManager.LoadScene ("Player Gal Wins");
			itsOver = true;
			playerGalHealth = maxHealth;
			playerGuyHealth = maxHealth;
		}
			
	}
		
}
