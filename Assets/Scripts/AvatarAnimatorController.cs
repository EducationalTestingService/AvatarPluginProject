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
			avatarAnimator.Play("noSpeech", 1, 0);
			break;

		case "interview_intro":
			avatarAnimator.SetInteger("animState", 1);
			avatarAnimator.Play("interview_intro", 1, 0);
			avatarAnimator.Play("interview_Intro_Body", 0, 0);
			break;

		case "interview_Q1":
			avatarAnimator.SetInteger("animState", 2);
			avatarAnimator.Play("interview_Q1", 1, 0);
			avatarAnimator.Play("interview_Q1_Body", 0, 0);
			break;

		case "interview_Q2":
			avatarAnimator.SetInteger("animState", 3);
			avatarAnimator.Play("interview_Q2", 1, 0);
			avatarAnimator.Play("interview_Q2_Body", 0, 0);
			break;

		case "interview_Q3":
			avatarAnimator.SetInteger("animState", 4);
			avatarAnimator.Play("interview_Q3", 1, 0);
			avatarAnimator.Play("interview_Q3_Body", 0, 0);
			break;

		case "interview_Q4":
			avatarAnimator.SetInteger ("animState", 5);
			avatarAnimator.Play("interview_Q4", 1, 0);
			avatarAnimator.Play("interview_Q4_Body", 0, 0);
			break;

		case "interview_Q5":
			avatarAnimator.SetInteger("animState", 6);
			avatarAnimator.Play("interview_Q5", 1, 0);
			avatarAnimator.Play("interview_Q5_Body", 0, 0);
			break;

		case "interview_Q6":
			avatarAnimator.SetInteger("animState", 7);
			avatarAnimator.Play("interview_Q6", 1, 0);
			avatarAnimator.Play("interview_Q6_Body", 0, 0);
			break;

		case "interview_Q7":
			avatarAnimator.SetInteger("animState", 8);
			avatarAnimator.Play("interview_Q7", 1, 0);
			avatarAnimator.Play("interview_Q7_Body", 0, 0);
			break;

		case "interview_Default":
			avatarAnimator.SetInteger("animState", 9);
			avatarAnimator.Play("interview_Default", 1, 0);
			break;

		case "interview_Exit":
			avatarAnimator.SetInteger("animState", 10);
			avatarAnimator.Play("interview_Exit", 1, 0);
			avatarAnimator.Play("interview_Exit_Body", 0, 0);
			break;

		case "interview_complaintA":
			avatarAnimator.SetInteger("animState", 11);
			avatarAnimator.Play("interview_complaintA", 1, 0);
			break;

		case "interview_complaintB":
			avatarAnimator.SetInteger("animState", 12);
			avatarAnimator.Play("interview_complaintB", 1, 0);
			break;

		case "interview_complaintC":
			avatarAnimator.SetInteger("animState", 13);
			avatarAnimator.Play("interview_complaintC", 1, 0);
			break;

		case "interview_complaintD":
			avatarAnimator.SetInteger("animState", 14);
			avatarAnimator.Play("interview_complaintD", 1, 0);
			break;

		case "interview_DisagreementA":
			avatarAnimator.SetInteger("animState", 15);
			avatarAnimator.Play("interview_DisagreementA", 1, 0);
			break;

		case "interview_DisagreementB":
			avatarAnimator.SetInteger("animState", 16);
			avatarAnimator.Play("interview_DisagreementB", 1, 0);
			break;

		case "interview_DisagreementC":
			avatarAnimator.SetInteger("animState", 17);
			avatarAnimator.Play("interview_DisagreementC", 1, 0);
			break;

		case "interview_DisagreementD":
			avatarAnimator.SetInteger("animState", 18);
			avatarAnimator.Play("interview_DisagreementD", 1, 0);
			break;

		case "interview_CouponAB":
			avatarAnimator.SetInteger("animState", 19);
			avatarAnimator.Play("interview_CouponAB", 1, 0);
			break;

		case "interview_CouponC":
			avatarAnimator.SetInteger("animState", 20);
			avatarAnimator.Play("interview_CouponC", 1, 0);
			break;

		case "interview_CouponD":
			avatarAnimator.SetInteger("animState", 21);
			avatarAnimator.Play("interview_CouponD", 1, 0);
			break;

		case "smileAnim":
			avatarAnimator.SetInteger("animState", 22);
			break;

		default:
			print("Error has occured");
			break;
		}
	}
}
