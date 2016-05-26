using UnityEngine;
using System.Collections;

/**
 * Generic destroy game object method
 */ 
public class DestroyWhenHit : MonoBehaviour {

	public GameObject barrelGroup;

	private void OnTriggerEnter()
	{
		Destroy( gameObject );
	}
}


