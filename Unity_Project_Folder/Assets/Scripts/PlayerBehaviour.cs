using UnityEngine;
using System.Collections;

/**
 * Methods to deal with player variables such as life, does he have the wand 
 * 
 */ 
public class PlayerBehaviour : MonoBehaviour {

	public static int playerLife = 10;
	public AudioClip gotWandSound;


	//---------------------------------------------------------------------
	/**
	 * Setter method to decrease the player life value
	 */
	public static void DecreasePlayerLife (){
		playerLife--;
	}
	//-----------------------------------------------------------------------
	/**
	 * Setter method to increase the player life value
	 */
	public static void IncreasePlayerLife (){
		playerLife++;
		if (playerLife > 10) {
			playerLife = 10;		
		}
	}
	//-----------------------------------------------------------------------
	/**
	 * Setter method to increase the player life value
	 * Takes a value in to increase life by, but will max out at 10
	 */
	public static void IncreasePlayerLife (int lifeUp){
		playerLife += lifeUp;
		if (playerLife > 10) {
			playerLife = 10;		
		}
	}
	//-----------------------------------------------------------------------
	/**
	 * Getter method for the player life value
	 */
	public static int GetPlayerLife (){
		return playerLife;
	}
	//-----------------------------------------------------------------------
	public void OnTriggerEnter(Collider c){		
		string tag = c.tag;
		
		//Give player the magic wand
		if("WandCube" == tag){
			audio.PlayOneShot (gotWandSound);
		}

	}//end OnTriggerEnter


}//end class Player
