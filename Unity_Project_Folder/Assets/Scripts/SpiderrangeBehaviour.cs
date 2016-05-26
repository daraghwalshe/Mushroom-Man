using UnityEngine;
using System.Collections;

/**
 * A class attached to spider sensor area to make it shoot if entered by the player<br>
 * Not working exactly as hoped, so have used static accesors(all spiders shoot ! so it's a hack)
 */ 
public class SpiderrangeBehaviour : MonoBehaviour {

	//public ScriptableObject SpiderGunBehavior;
	public SpiderGunBehaviour mySpiderGun;

	/**
	 * if player gets into spider firing range
	 */
	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;	
		if("Player" == tag){
			SpiderGunBehaviour.SetPlayerInRange();
			//this.mySpiderGun = GetComponent<SpiderGunBehaviour>();
			//mySpiderGun.SetPlayerInRange();
		}
	}//end OnTriggerEnter
	//---------------------------------------------------
	/**
	 * if player leaves spider firing range
	 */
	public void OnTriggerExit(Collider c){
		
		string tag = c.tag;	
		if("Player" == tag){
			SpiderGunBehaviour.SetPlayerNotInRange();
		}
	}//end OnTriggerExit
	//---------------------------------------------------



}
