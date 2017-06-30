using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAnimatorController : MonoBehaviour {

	Animator avatarAnimator;
	public string animationName;

	// Use this for initialization
	void Start () {
		avatarAnimator = GetComponent<Animator>();
	}

	public void UpdateAnimations(string animationName)
	{
		switch (animationName)
		{
		case "idleAnim":
			avatarAnimator.SetInteger("animState", 0);
			break;

		case "raiseRightArmAnim":
			avatarAnimator.SetInteger("animState", 1);
			break;

		case "raiseLeftArmAnim":
			avatarAnimator.SetInteger("animState", 2);
			break;

		case "nodAnim":
			avatarAnimator.SetInteger("animState", 3);
			break;

		default:
			print("Error has occured");
			break;
		}
	}
}
