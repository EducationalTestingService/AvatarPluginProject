using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public float aspectWidth = 16f;
	public float aspectHeight = 9f;
	public float aspectRatio;
	public float camFoV = 75f;


	// Use this for initialization
	void Start () {		
		aspectWidth = 640f;
		aspectHeight = 360f;
		aspectRatio = 1.7f;
		camFoV = 39f;
	}
	
	// Update is called once per frame
	void Update () {
		aspectRatio = aspectWidth / aspectHeight;
		FindObjectOfType<Camera> ().aspect = aspectRatio;
		FindObjectOfType<Camera> ().fieldOfView = camFoV;
	}
}
