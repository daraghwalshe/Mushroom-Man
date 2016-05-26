using UnityEngine;
using System.Collections;

/**
 * Dr. Matt Smith's countdown timer script<br>
 * Called by OnGUI to check proportion of level-time left<br>
 * Note: This is not my work
 */ 
public class CountdownTimer : MonoBehaviour 
{
	private float countdownTimerStartTime;
	private int countdownTimerDuration;

	//public static int timeAdjustment = 0;

	public int GetTotalSeconds()
	{
		return countdownTimerDuration;
	}

	public void ResetTimer(int seconds)
	{
		countdownTimerStartTime = Time.time;
		countdownTimerDuration = seconds;
	}
	
	public int GetSecondsRemaining()
	{
		int elapsedSeconds = (int)(Time.time - countdownTimerStartTime);
		int secondsLeft = (countdownTimerDuration - elapsedSeconds);
		return secondsLeft;
	}

	public float GetProportionTimeRemaining()
	{
		float proportionLeft = (float)GetSecondsRemaining() / (float)GetTotalSeconds();
		return proportionLeft;
	}
	//---------------------------------------------------------


}




