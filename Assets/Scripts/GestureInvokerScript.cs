using System.Collections;
using UnityEngine;

public class GestureInvokerScript : MonoBehaviour {

	float randomBlinkInterval;
	float randomNodInterval;
	Animator animator;

	void Start()
	{
		animator = GetComponent<Animator> ();
	}

	public void StartBlinkCoroutine()
	{
		randomBlinkInterval = Random.Range (1f, 8f);
		StartCoroutine (BlinkIntervalLogic(randomBlinkInterval));
	}
	
	IEnumerator BlinkIntervalLogic(float randomBlinkInterval)
	{
		while (randomBlinkInterval > 0)
		{
			randomBlinkInterval = randomBlinkInterval - Time.deltaTime;
			yield return null;
		} 
		yield return null;
		StartBlinkCoroutine ();
		BlinkCall ();
	}

	private void BlinkCall()
	{			
		animator.SetInteger ("animStateGestures", 1);
	}

	private void BlinkFinished()
	{
		animator.SetInteger ("animStateGestures", 0);
	}

	public void StartNodCoroutine()
	{
		randomNodInterval = Random.Range (3f, 9f);
		StartCoroutine (NodIntervalLogic(randomNodInterval));
	}

	IEnumerator NodIntervalLogic(float randomBlinkInterval)
	{
		while (randomNodInterval > 0)
		{
			randomNodInterval = randomNodInterval - Time.deltaTime;
			yield return null;
		} 
		yield return null;
		StartNodCoroutine ();
		NodCall ();
	}

	private void NodCall()
	{			
		animator.SetInteger ("animStateNods", 1);
	}

	private void NodFinished()
	{			
		animator.SetInteger ("animStateNods", 0);
	}
}
