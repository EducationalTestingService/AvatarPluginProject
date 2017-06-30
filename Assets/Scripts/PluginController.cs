using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PluginController : MonoBehaviour 
{

	AvatarAnimatorController avatarAC;
	string returnString = "blank";
	string returnNum = "blank";
	string numberToPass = "blank";

	void Start () 
	{
		avatarAC = FindObjectOfType<AvatarAnimatorController> ();
	}

	[DllImport("__Internal")]
	private static extern void callAnimation (string animValue);

	public void pluginAnimationReturn(string returnString)
	{
		avatarAC.UpdateAnimations (returnString);
	}

	[DllImport("__Internal")]
	private static extern void passNum (string numValue);

	public void pluginNumberReturn(string returnNum)
	{
		int stringToInt = System.Convert.ToInt32 (returnNum);
		Debug.Log("Our javascript processed, returned number is " + stringToInt);
	}

	[DllImport("__Internal")]
	private static extern void speakNow ();

	void Update () {

		if (Input.GetKeyDown(KeyCode.Q))
		{
			#if !UNITY_EDITOR
			callAnimation ("idleAnim");
			#endif
			avatarAC.UpdateAnimations ("idleAnim");
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			#if !UNITY_EDITOR
			callAnimation ("raiseRightArmAnim");
			#endif
			avatarAC.UpdateAnimations ("raiseRightArmAnim");
		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			#if !UNITY_EDITOR
			callAnimation ("raiseLeftArmAnim");
			#endif
		}

		if (Input.GetKeyDown(KeyCode.R))
		{	
			#if !UNITY_EDITOR
			callAnimation ("nodAnim");
			#endif
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{			
			#if !UNITY_EDITOR
			numberToPass = UnityEngine.Random.Range (1, 999).ToString();
			passNum (numberToPass);
			#endif
		}
	}
}
