using UnityEngine;
using System.Collections;


/**
 * A script to handle the behaviour of the toxic barrel group
 * how many hits to destroy<br> 
 * What happens when group are destroyed
 */
public class BarrelBehaviour2 : MonoBehaviour {
		
	/** reference to the ToxicBarrelGO */
	public GameObject barrelGroup;
	public GameObject explosionPrefab;
	public AudioClip explosionSound;
	
	
	//barrel must be hit by x magic bullets to die
	public int barrelLife = 30;
	
	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		/**start explosions if barrel life less than 11*/
		if("MagicBullet" == tag){
			barrelLife--;
			if(barrelLife < 11){
				GameObject newExplosionGO = (GameObject)Instantiate(explosionPrefab, transform.position, Quaternion.identity);
				Destroy( newExplosionGO, 5);
			}
		}


		//-----------------------------------------------
		/**start sounds if barrel life less than 6*/
		if("MagicBullet" == tag){
			if(barrelLife < 6){
				audio.PlayOneShot(explosionSound);
			}
		}
		
		/**destroy barrel method call*/
		if("MagicBullet" == tag){
			if(barrelLife < 0){
				GameGUI.DecreaseBarrelsLeft ();
				Destroy( barrelGroup );
			}
		}
		
	}//end OnTriggerEnter
		
	//-----------------------------------
	// Update is called once per frame
	void Update () {}
	//-----------------------------------


}//end class



