using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour {

	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	public void PlayAudio(string audioClipName)
	{
		switch (audioClipName)
		{
		case "interview_intro":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_intro");
			audioSource.Play ();
			break;

		case "interview_Q1":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Q1");
			audioSource.Play ();
			break;

		case "interview_Q2":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Q2");
			audioSource.Play ();
			break;

		case "interview_Q3":
			audioSource.clip = Resources.Load <AudioClip> ("Audio/interview_Q3");
			audioSource.Play ();
			break;

		case "interview_Q4_complaint":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Q4_complaint");
			audioSource.Play ();
			break;

		case "interview_Q5_Disagreement":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Q5_Disagreement");
			audioSource.Play ();
			break;

		case "interview_Q6_Coupon":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Q6_Coupon");
			audioSource.Play ();
			break;

		case "interview_Q7":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Q7");
			audioSource.Play ();
			break;

		case "interview_complaintA":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_complaintA");
			audioSource.Play ();
			break;

		case "interview_complaintB":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_complaintB");
			audioSource.Play ();
			break;

		case "interview_complaintC":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_complaintC");
			audioSource.Play ();
			break;

		case "interview_complaintD":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_complaintD");
			audioSource.Play ();
			break;

		case "interview_CouponAB":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_CouponAB");
			audioSource.Play ();
			break;

		case "interview_CouponC":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_CouponC");
			audioSource.Play ();
			break;

		case "interview_CouponD":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_CouponD");
			audioSource.Play ();
			break;

		case "interview_DisagreementA":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_DisagreementA");
			audioSource.Play ();
			break;

		case "interview_DisagreementB":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_DisagreementB");
			audioSource.Play ();
			break;

		case "interview_DisagreementC":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_DisagreementC");
			audioSource.Play ();
			break;

		case "interview_DisagreementD":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_DisagreementD");
			audioSource.Play ();
			break;

		case "interview_Default":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Default");
			audioSource.Play ();
			break;

		case "interview_Exit":
			audioSource.clip = Resources.Load <AudioClip>("Audio/interview_Exit");
			audioSource.Play ();
			break;

		default:
			print("Error has occured");
			break;
		}

	}
}
