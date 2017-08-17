using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PluginController : MonoBehaviour 
{

	AvatarAnimatorController avatarAC;
	string returnString = "blank";
	string returnNum = "blank";
	string numberToPass = "blank";
	AudioManagerScript aMS;
	Animator animator;
	public Animation targetAnim;

	void Start () 
	{
		avatarAC = FindObjectOfType<AvatarAnimatorController> ();
		aMS = FindObjectOfType<AudioManagerScript> ();
		animator = GetComponent<Animator> ();


		#if !UNITY_EDITOR
		FindObjectOfType<GestureInvokerScript> ().StartNodCoroutine ();
		FindObjectOfType<GestureInvokerScript> ().StartBlinkCoroutine ();
		animator.SetInteger ("animBodyState", 1);
		#endif
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
		Console.WriteLine ("Our javascript processed, returned number is " + stringToInt);

	}

	[DllImport("__Internal")]
	private static extern void callAudio (string audioFile);

	public void pluginAudioReturn(string returnAudioString)
	{
		aMS.PlayAudio (returnAudioString);
	}

	public void commandReceiver(string returnCommandString)
	{
		avatarAC.UpdateAnimations (returnCommandString);
		aMS.PlayAudio (returnCommandString);
	}

}
