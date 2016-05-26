using UnityEngine;
using System.Collections;

/**
 * IMM Project April 2014		B00064428 Daragh Walshe
 */

/**
 *  Game GUI class to manage HUD displays<br>
 *  Time Remaining, Players health, Barrels remaining etc.
 */
public class GameGUI: MonoBehaviour {

	public Texture2D greenTime;
	public Texture2D redTime;
	public Texture2D hourglass;
	public Texture2D lifeHeart;

	public Texture2D toxicBarrel;
	public Texture2D magicWand;

	//The next level - made public for adjustment in inspector
	public int LevelToLoad = 7;
	public int GameOverLevel = 5;
	public int GameWonLevel = 8;
	public Font thisFont;

	private static int barrelsLeft = 3;
	private static int pipesLeft = 2;
	private static bool finalLevel;
	public static int playerLife = 10;
	
	private CountdownTimer myTimer;

	//used to help build the GUI
	int width = (Screen.width / 20);

	private void Start() 
	{ 
		myTimer = GetComponent<CountdownTimer>(); 
	}
		
	private void OnGUI()
	{
		//LHS GUI HUD
		DrawLifeBar ();
		DrawBarrelsLeft ();

		//RHS GUI HUD
		DrawTimeBar ();
		CheckLevelOver ();
	}
	//------------------------------------------------------------------------
	/**
	 * Loop ten times and place either a red or green block in a vertical array
	 * depending on proportion of time left. Displayed on RHS of screen.
	 */
	private void DrawTimeBar() 
	{
		float proportionTimeRemaining = myTimer.GetProportionTimeRemaining();
		float baseTime = 0.9f;
		int xPosition = ((Screen.width/20)*19);//int xPosition = ((Screen.width/20)*19)+15;
		int yPosition = 0;

		GUI.Label (new Rect (xPosition+6,0,width,40), hourglass);
		
		for (int i=0; i<10; i++) {

			//adjust y position each loop
			yPosition = 40+(i*20);

			//loop 10 times and check time left against basetime(0.9) 
			//and decrement basetime each loop by 0.1
			if(baseTime < proportionTimeRemaining){
				GUI.Label(new Rect(xPosition+6,yPosition,width,20), greenTime);
				baseTime -= 0.1f;
			}
			else{
				GUI.Label(new Rect(xPosition+6,yPosition,width,20), redTime);
				//GUI.Label(new Rect(xPosition+6,yPosition,width,20), redTime);
				baseTime -= 0.1f;
			}
		}
		DrawWand (yPosition);

	}
	//-----------------------------------------------------------------------
	/**
	 * Draw the wand on the HUD when player collects
	 */
	public void DrawWand (int yPositionIn){
		
		if (FireProjectile.PlayerHasWand ()) {
			yPositionIn += 20;
			int xPosition = ((Screen.width/20)*19);
			GUI.Label (new Rect (xPosition+6,yPositionIn,width,50), magicWand);				
		}
		
	}
	//--------------------------------------------------------------------
	/**
	 * Loop ten times and place either a red or green block in a vertical stack
	 * depending on proportion of time left.<br> Shown on LHS of the screen.
	 */
	private void DrawLifeBar() 
	{
		int playerLife = PlayerBehaviour.GetPlayerLife();
		int baseLife = 9;

		GUI.Label (new Rect (0,0,width,40), lifeHeart);
		//GUI.Box (new Rect (0,0,80,40), lifeHeart)
		
		//loop 10 times and check life left against baselife
		for (int i=0; i<10; i++) {
			int yPosition = 40+(i*20);
			if(baseLife < playerLife){
				GUI.Label(new Rect(0,yPosition,width,20), greenTime);
				baseLife -= 1;
			}
			else{
				GUI.Label(new Rect(0,yPosition,width,20), redTime);
				baseLife -= 1;
			}
		}
	}
	//------------------------------------------------------------------------
	//--------------------------------------------------------------------	
	/**
	 * Check to see if all the Barrels are Destroyed, or if player is dead
	 */
	public GameObject nextLevelMessage;

	/**
	 * <b>Performs two checks:
	 * <ol><li>Has all barrels been destroyed, if so go to next level
	 * 	   <li>Is the players life > 0, if not go to game over level
	 * 
	 */ 
	private void CheckLevelOver() 
	{
		if(barrelsLeft == 0 && !finalLevel){
			//Instantiate(nextLevelMessage); //not working ??
			Application.LoadLevel(LevelToLoad);
		}
		if(barrelsLeft == 0 && finalLevel){
			CheckFinalOver();
		}
		if(PlayerBehaviour.GetPlayerLife() < 0){
			Application.LoadLevel(GameOverLevel);
		}
	}
	//--------------------------------------------------------------------
	
	/**
	 * Loop to check number factory outlet pipes left to win game
	 * 
	 */
	private void CheckFinalOver() 
	{
		if(pipesLeft == 0)
			Application.LoadLevel(GameWonLevel);
	}
	//--------------------------------------------------------------------
	/**
	 * Loop to check number of barrels left this level, and draw on HUD
	 * 
	 */
	private void DrawBarrelsLeft() 
	{
		//GUI.Label (new Rect (0, 250, width, 40+(barrelsLeft*62)), "Barrels");
		GUI.Box (new Rect (0,250,61,40),"Barrels");
		int yPosition = 290;
		for (int i=0; i<barrelsLeft; i++) {
			GUI.Label(new Rect(0,yPosition,width,62), toxicBarrel);
			yPosition += 62;

		}
	}
	//-----------------------------------------------------------------------
	/**
	 * Method to decrease the number of barrels left this level
	 */
	public static void DecreaseBarrelsLeft (){
		barrelsLeft--;
	}
	//-----------------------------------------------------------------------
	/**
	 * Setter for the number of barrels left this level
	 */
	public static void SetBarrelsLeft (int barrelsIn){
		barrelsLeft = barrelsIn;
	}
	//-----------------------------------------------------------------------
	/**
	 * Setter for if final level boolean
	 */
	public static void SetFinalLevel (bool finalIn){
		finalLevel = finalIn;
	}
	//-----------------------------------------------------------------------
	/**
	 * Method to decrease the number of factory pipes
	 */
	public static void DecreasePipesLeft (){
		pipesLeft--;
	}
	//-----------------------------------------------------------------------





} //end class












