using UnityEngine;
using System.Collections;

/**
 * A script for the toxic area around a barrel group<br>
 * Attached to a seperate sphere with collider, attached to the barrel group
 */ 
public class ToxicAreaBehaviour : MonoBehaviour {

	public AudioClip hurtSound;

	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		/**
		 * decrease players life by one
		 */ 
		if("Player" == tag){
			PlayerBehaviour.DecreasePlayerLife();
			audio.PlayOneShot (hurtSound);

		}
		
	}//end OnTriggerEnter


}
