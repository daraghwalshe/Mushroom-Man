using UnityEngine;
using System.Collections;

/**
 * A class to control spider life and death
 * 
 */ 
public class SpiderLifeBehaviour : MonoBehaviour {

	/** reference to the spiderGO */
	public GameObject spider;
	public AudioClip spiderDie;

	//spider must be hit by x magic bullets to die
	public int spiderLife = 10;


	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		/**start explosions if barrel life less than 11*/
		if("MagicBullet" == tag){
			spiderLife--;

			if(spiderLife < 5){
				audio.PlayOneShot (spiderDie);
			}

			if(spiderLife < 0){
				Destroy( spider, 5);
			}
		}

		
	}//end OnTriggerEnter


}
