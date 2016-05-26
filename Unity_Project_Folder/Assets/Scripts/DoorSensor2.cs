﻿using UnityEngine;
using System.Collections;

public class DoorSensor2 : MonoBehaviour {
	public GameObject cubeGO;
	
	private bool doorIsAlreadyOpen = false;
	public AudioClip doorSound;
	
	private void OnTriggerEnter(Collider playerGO)
	{
		if(!doorIsAlreadyOpen)
		{
			OpenDoor();
		}		
	}

	
	private void OpenDoor()
	{
		Animation caveDoor2 = cubeGO.animation;
		caveDoor2.Play();
		audio.PlayOneShot (doorSound);
	}
}
