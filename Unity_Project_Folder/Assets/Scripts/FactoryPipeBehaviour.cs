using UnityEngine;
using System.Collections;

/**
 * A class to control factory pipes and set the changing of values for <br>
 * end of game victory condition
 */ 
public class FactoryPipeBehaviour : MonoBehaviour {

	/** reference to the FactoryPipeGO */
	public GameObject FactoryPipe;
	public GameObject explosionPrefab;
	
	
	//barrel must be hit by x magic bullets to die
	public int pipeLife = 30;
	
	public void OnTriggerEnter(Collider c){
		
		string tag = c.tag;
		
		/**start explosions if pipe life less than 15*/
		if("MagicBullet" == tag){
			pipeLife--;
			if(pipeLife < 11){
				GameObject newExplosionGO = (GameObject)Instantiate(explosionPrefab, transform.position, Quaternion.identity);
				Destroy( newExplosionGO, 5);
			}
		}
		
		/**destroy barrel method call*/
		if("MagicBullet" == tag){
			if(pipeLife < 0){
				GameGUI.DecreasePipesLeft ();
				Destroy( FactoryPipe );
				print ("pipe destroyed");
			}
		}
		
	}//end OnTriggerEnter

}
