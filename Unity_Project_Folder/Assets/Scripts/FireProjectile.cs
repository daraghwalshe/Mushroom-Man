// file: FireProjectile.cs	
using UnityEngine;
using System.Collections;

/**
 * Provided by Dr Matt Smith<br>
 * A class to fire projectiles, used with characters 'magic wand'
 * Added a boolean to disable the wand action till WandCube is picked up
 * Added two methods to control whether the player has the wand or not
 */ 
public class FireProjectile : MonoBehaviour 
{
	public Rigidbody projectilePrefab;
	private const float MIN_Y = -1;
	private float projectileSpeed = 20f;
	
	/** shortest time between firing */
	public const float FIRE_DELAY = 0.15f;
	private float nextFireTime = 0f;
	
	private static bool hasMagicWand = false;


	void Update() {
		if( Time.time > nextFireTime )
			CheckFireKey();
	}	
	

	/**
	 * Checks if player has wagic wand before firing
	 */ 
	void CheckFireKey() {

		if(hasMagicWand){
			if( Input.GetButton("Fire1")) {
				CreateProjectile();
				
				// enssure a delay before next projectile can be fired
				nextFireTime = Time.time + FIRE_DELAY;
			}
		}//end if-true
	}
	//------------------------------------------------------------------------	
	/**
	 * Create clones of projectile as magic bullets from players wand
	 */
	void CreateProjectile() {
	    Rigidbody projectile = (Rigidbody)Instantiate(projectilePrefab, transform.position, transform.rotation);
		
	    // create and apply velocity 
		Vector3 projectileVelocity = (projectileSpeed * Vector3.forward);
		// - need to use TransformDirection() so direciton is releative to current direction camera is facing
	    projectile.velocity = transform.TransformDirection( projectileVelocity );

		Destroy( projectile.gameObject, 1.0f);
	}   
	//------------------------------------------------------------------------	
	/**
	 * A method to give the player the magic wand<br>
	 * called from the WandCubeBehaviour script
	 */
	public static void SetMagicWand(bool wandCondition) {
		hasMagicWand = wandCondition;
	}
	//------------------------------------------------------------------------	
	/**
	 * A method to find if the player has the magic wand<br>
	 * called from the GameGUI script
	 */
	public static bool PlayerHasWand() {
		return hasMagicWand;
	}


}
