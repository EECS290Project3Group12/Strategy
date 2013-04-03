using UnityEngine;
using System.Collections;

public class ColorUnit : MonoBehaviour {
	
	
	//Default texture
	public Texture defaultTexture;
	
	//Hover texture
	public Texture hoverTexture;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseEnter ()
	{
		renderer.material.mainTexture = hoverTexture;
	}
	
	void OnMouseExit()
	{
		renderer.material.mainTexture = defaultTexture;
	}
	
	void OnMouseDown()
	{
		Debug.Log ("Selected" + this.ToString ());
	}
}
