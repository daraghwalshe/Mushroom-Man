using UnityEngine;
using System.Collections;

/**
 * Simple class to set a boolean to give player the magic wand
 */ 
public class WandCubeBehaviour : MonoBehaviour {

	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		//Give player the magic wand
		if("Player" == tag){
			FireProjectile.SetMagicWand(true);
			Destroy(gameObject);
		}
	}//end OnTriggerEnter
}
