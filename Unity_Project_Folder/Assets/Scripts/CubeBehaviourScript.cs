using UnityEngine;
using System.Collections;

public class CubeBehaviourScript : MonoBehaviour {

	//private GameGUI myGUI;
	//public ScriptableObject GameGUI;
	//myGUI = GetComponent<GameGUI>();//myTimer = GetComponent<CountdownTimer>(


	private void Start() 
	{
		//myGUI = GetComponent<GameGUI>();
	}



	private void OnTriggerEnter()
	{
		Destroy( gameObject );
		GameGUI.DecreaseBarrelsLeft ();
	}

}
