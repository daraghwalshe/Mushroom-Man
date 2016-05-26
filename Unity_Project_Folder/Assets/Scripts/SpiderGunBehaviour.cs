using UnityEngine;
using System.Collections;

/**
 * A script to control the behaviour of the spider gun<br>
 * Which is the prefab attached to spiders which shoot at the player
 * It is an adaptation of Dr Matt Smith's FireProjectile script
 * 
 */ 
public class SpiderGunBehaviour : MonoBehaviour {

	public Rigidbody projectilePrefab;
	private const float MIN_Y = -1;
	private float projectileSpeed = 15f;
	
	/** shortest time between firing */
	public const float FIRE_DELAY = 0.50f;
	private float nextFireTime = 0f;
	
	private static bool isPlayerInRange = false;
	//private bool isPlayerInRange = false;
	
	void Update() {
		if( Time.time > nextFireTime )
			CheckForPlayer();
		//CheckPlayerInRange();
	}	
	
	
	/**
	 * Checks if player is in range before firing
	 */ 
	void CheckForPlayer() {
		if( isPlayerInRange ) {
				CreateProjectile();
				// enssure a delay before next projectile can be fired
				nextFireTime = Time.time + FIRE_DELAY;
			}
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
	 * A method to confirm player in firing range<br>
	 */
	public static void SetPlayerInRange() {
		isPlayerInRange = true;
	}
	//------------------------------------------------------------------------	
	/**
	 * A method to confirm player not in firing range<br>
	 */
	public static void SetPlayerNotInRange() {
		isPlayerInRange = false;
	}

	/*
	public void SetPlayerInRange() {
		isPlayerInRange = true;
	}*/

}
