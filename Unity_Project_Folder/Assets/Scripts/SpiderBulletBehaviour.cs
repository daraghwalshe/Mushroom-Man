using UnityEngine;
using System.Collections;

/**
 * class for spider bullets, hurt player and play a sound
 */ 
public class SpiderBulletBehaviour : MonoBehaviour {

	public AudioClip hurtSound;
	
	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		/**decrease players life by one*/
		if("Player" == tag){
			PlayerBehaviour.DecreasePlayerLife();
			audio.PlayOneShot (hurtSound);	
		}
		
	}//end OnTriggerEnter
}
