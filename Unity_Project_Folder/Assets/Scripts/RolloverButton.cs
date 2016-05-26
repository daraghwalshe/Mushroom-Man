using UnityEngine;
using System.Collections;

/**
 * Used to enable buttons for GUI menus
 */ 
public class RolloverButton : MonoBehaviour {
	public int levelToLoadOnClick = 1;
	public Texture2D normalImage;
	public Texture2D rolloverImage;
	
	private void OnMouseOver(){
		guiTexture.texture = rolloverImage;
	}
	
	private void OnMouseExit(){
		guiTexture.texture = normalImage;		
	}
	
	private void OnMouseUp(){
		Application.LoadLevel( levelToLoadOnClick );
	}
}
