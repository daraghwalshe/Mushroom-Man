using UnityEngine;
using System.Collections;


/**
 * A class to set various gameplay elements such as:<br>
 * How many barrels to destroy on any given level, time for level etc
 */ 
public class GameManager : MonoBehaviour 
{
	public int timeForLevel = 20;
	private CountdownTimer myTimer;
	public int gameOverLevelIndex = 5;
	public int barrelsForLevel = 3;
	public bool isFinalLevel = false;
	public bool playerHasWand = false;

	private void Start() 
	{
		myTimer = GetComponent<CountdownTimer>();
		myTimer.ResetTimer(timeForLevel); 

		GameGUI.SetBarrelsLeft (barrelsForLevel);
		//print ("BARRELS FOR LEVEL" + barrelsForLevel);
		GameGUI.SetFinalLevel (isFinalLevel);

		FireProjectile.SetMagicWand (playerHasWand);
	}

	/**
	 * Check to see if player has run out of time
	 */ 
	private void Update() 
	{
		int secondsLeft = myTimer.GetSecondsRemaining();
		if(secondsLeft < 0)
		{
			Application.LoadLevel(gameOverLevelIndex); 
		}
	}

}









