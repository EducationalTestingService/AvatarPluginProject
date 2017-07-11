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

		case "interview_intro":
			avatarAnimator.SetInteger("animState", 1);
			break;

		case "interview_Q1":
			avatarAnimator.SetInteger("animState", 2);
			break;

		case "interview_Q2":
			avatarAnimator.SetInteger("animState", 3);
			break;

		case "interview_Q3":
			avatarAnimator.SetInteger("animState", 4);
			break;

		case "interview_Q4":
			avatarAnimator.SetInteger("animState", 5);
			break;

		case "interview_Q5":
			avatarAnimator.SetInteger("animState", 6);
			break;

		case "interview_Q6":
			avatarAnimator.SetInteger("animState", 7);
			break;

		case "interview_Q7":
			avatarAnimator.SetInteger("animState", 8);
			break;

		case "interview_Default":
			avatarAnimator.SetInteger("animState", 9);
			break;

		case "interview_Exit":
			avatarAnimator.SetInteger("animState", 10);
			break;

		case "smileAnim":
			avatarAnimator.SetInteger("animState", 11);
			break;

		case "interview_complaintA":
			avatarAnimator.SetInteger("responseQ4", 1);
			break;

		case "interview_complaintB":
			avatarAnimator.SetInteger("responseQ4", 2);
			break;

		case "interview_complaintC":
			avatarAnimator.SetInteger("responseQ4", 3);
			break;

		case "interview_complaintD":
			avatarAnimator.SetInteger("responseQ4", 4);
			break;

		case "interview_DisagreementA":
			avatarAnimator.SetInteger("responseQ5", 1);
			break;

		case "interview_DisagreementB":
			avatarAnimator.SetInteger("responseQ5", 2);
			break;

		case "interview_DisagreementC":
			avatarAnimator.SetInteger("responseQ5", 3);
			break;

		case "interview_DisagreementD":
			avatarAnimator.SetInteger("responseQ5", 4);
			break;

		case "interview_CouponAB":
			avatarAnimator.SetInteger("responseQ6", 1);
			break;

		case "interview_CouponC":
			avatarAnimator.SetInteger("responseQ6", 2);
			break;

		case "interview_CouponD":
			avatarAnimator.SetInteger("responseQ6", 3);
			break;

		default:
			print("Error has occured");
			break;
		}
	}
}
