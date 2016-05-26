using UnityEngine;
using System.Collections;


/**
 * <b>A script with on triggger enter and ontrigger exit methods
 * to turn on and off the mushroom circle behaviour
 */
public class MushroomCircleBehaviour : MonoBehaviour {

	public AudioClip magicSound;
	public GameObject bubbleEmitter;
	public int PlayerLifeUpValue = 4;

	//variables to control life up for a given time in the circle
	private bool playerInCircle = false;
	private float nextLifeTime = 1.0f;

	private float startTime;


	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		//create bubble effect and increase players life
		if("Player" == tag){
			print ("enter circle");
			GameObject thisBubbleEmitter = (GameObject)Instantiate(bubbleEmitter, transform.position, Quaternion.identity);
			//PlayerBehaviour.IncreasePlayerLife(PlayerLifeUpValue);
			playerInCircle = true;
//startTime = Time.realTimeSinceStartup();
			Destroy (thisBubbleEmitter, 7);
		}	
	}//end OnTriggerEnter
	//---------------------------------------------------

	public void OnTriggerExit(Collider c){
		
		string tag = c.tag;
		
		//destroy the circle ??
		if("Player" == tag){
			print ("exit circle");
			//Destroy(thisBubbleEmitter);
			playerInCircle = false;
		}	
	}//end OnTriggerEnter

	//---------------------------------------------------
	/**
	 * Time check to see if the player is still in the circle
	 * if true player will get 1 life per nextLifeTime
	 */ 
	/*
	void Update() {
		if (playerInCircle) {
			if( Time.time > nextLifeTime ){
				PlayerBehaviour.IncreasePlayerLife();
			}
		}
	}*///end update


	private float nextLife = 0.0f;
	void Update () {
		if (playerInCircle && Time.time > nextLife) {
			nextLife = Time.time + nextLifeTime;
			PlayerBehaviour.IncreasePlayerLife();
		}
	}

}//end MushroomCircleBehaviour








