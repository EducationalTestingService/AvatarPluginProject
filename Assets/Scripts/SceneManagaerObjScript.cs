using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagaerObjScript : MonoBehaviour {

//	public static SceneManagaerObjScript instance = null;

//	void Awake() 
//	{
//		if (instance == null)
//		{
//			instance = this;
//		}
//		else
//		{
//			Destroy(gameObject);
//		}
//		DontDestroyOnLoad(this.gameObject);
//	}

	public void InitiateCallIn()
	{
			Application.ExternalCall ("initiateCallIn");
			SceneManager.LoadScene ("MainScene");
	}

	public void InitiateHangUp()
	{
		Application.ExternalCall ("initiateHangUp");
	}

	public void LoadLevel(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
}
