using UnityEngine;
using System.Collections;

public class MenuItems : MonoBehaviour {
	
	public FontStyle defaultStyle;
	
	public FontStyle hoverStyle;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseEnter ()
	{
		guiText.fontStyle = hoverStyle;
	}
	
	void OnMouseExit()
	{
		guiText.fontStyle = defaultStyle;
	}
}
