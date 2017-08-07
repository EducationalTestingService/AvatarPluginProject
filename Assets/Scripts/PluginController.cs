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

	void Update () {

		if (Input.GetKeyDown(KeyCode.Q))
		{
			#if !UNITY_EDITOR
			callAnimation ("idleAnim");
			#endif
			avatarAC.UpdateAnimations ("idleAnim");
			//animator.CrossFade ("interview_Idle", .2f, 0);
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			#if !UNITY_EDITOR
			callAnimation ("additiveNodAnim");
			#endif
			avatarAC.UpdateAnimations ("additiveNodAnim");
		}

		if (Input.GetKeyDown(KeyCode.Keypad1))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_intro");
			callAudio ("interview_intro");
			#endif
			avatarAC.UpdateAnimations ("interview_intro");
			aMS.PlayAudio ("interview_intro");
		}

		if (Input.GetKeyDown(KeyCode.Keypad2))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q1");
			callAudio ("interview_Q1");
			#endif
			avatarAC.UpdateAnimations ("interview_Q1");
			aMS.PlayAudio ("interview_Q1");
		}

		if (Input.GetKeyDown(KeyCode.Keypad3))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q2");
			callAudio ("interview_Q2");
			#endif
			avatarAC.UpdateAnimations ("interview_Q2");
			aMS.PlayAudio ("interview_Q2");
		}

		if (Input.GetKeyDown(KeyCode.Keypad4))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q3");
			callAudio ("interview_Q3");
			#endif
			avatarAC.UpdateAnimations ("interview_Q3");
			aMS.PlayAudio ("interview_Q3");
		}

		if (Input.GetKeyDown(KeyCode.Keypad5))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q4");
			callAudio ("interview_Q4_complaint");
			#endif
			avatarAC.UpdateAnimations ("interview_Q4");
			aMS.PlayAudio ("interview_Q4_complaint");
		}

		if (Input.GetKeyDown(KeyCode.Keypad6))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q5");
			callAudio ("interview_Q5_Disagreement");
			#endif
			avatarAC.UpdateAnimations ("interview_Q5");
			aMS.PlayAudio ("interview_Q5_Disagreement");
		}

		if (Input.GetKeyDown(KeyCode.Keypad7))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q6");
			callAudio ("interview_Q6_Coupon");
			#endif
			avatarAC.UpdateAnimations ("interview_Q6");
			aMS.PlayAudio ("interview_Q6_Coupon");
		}

		if (Input.GetKeyDown(KeyCode.Keypad8))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Q7");
			callAudio ("interview_Q7");
			#endif
			avatarAC.UpdateAnimations ("interview_Q7");
			aMS.PlayAudio ("interview_Q7");
		}

		if (Input.GetKeyDown(KeyCode.Keypad9))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Default");
			callAudio ("interview_Default");
			#endif
			avatarAC.UpdateAnimations ("interview_Default");
			aMS.PlayAudio ("interview_Default");
		}

		if (Input.GetKeyDown(KeyCode.KeypadPlus))
		{	
			#if !UNITY_EDITOR
			callAnimation ("interview_Exit");
			callAudio ("interview_Exit");
			#endif
			avatarAC.UpdateAnimations ("interview_Exit");
			aMS.PlayAudio ("interview_Exit");
		}

		if (Input.GetKeyDown(KeyCode.KeypadDivide))
		{
			//#if UNITY_EDITOR
			animator.SetInteger ("animBodyState", 1);
			//#endif
		}

		if (Input.GetKeyDown(KeyCode.KeypadMultiply))
		{
			//#if UNITY_EDITOR
			FindObjectOfType<GestureInvokerScript> ().StartBlinkCoroutine ();
			//#endif
		}

		if (Input.GetKeyDown(KeyCode.KeypadMinus))
		{
			//#if UNITY_EDITOR
			FindObjectOfType<GestureInvokerScript> ().StartNodCoroutine ();
			//#endif
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
