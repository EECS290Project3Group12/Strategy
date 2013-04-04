using UnityEngine;
using System.Collections;

public class ColorUnit : MonoBehaviour {
	
	Vector3 boxPos;
	bool boxOpen = false;
	//Default texture
	public Texture defaultTexture;
	
	//Hover texture
	public Texture hoverTexture;	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(boxOpen && Input.GetMouseButtonDown(1)) {
			boxOpen = false;
		}
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
		boxPos.x = Input.mousePosition.x;
		boxPos.y = Screen.height - Input.mousePosition.y;
		boxOpen = true;
		Debug.Log ("Selected" + this.ToString ());
		
	}
	
	void OnGUI() {
		if(boxOpen) {
			Rect menu = new Rect(boxPos.x, boxPos.y, 100, 95);
			GUI.BeginGroup(menu);
		
			if(GUI.Button(new Rect(5,5,90,25), "Move")) {
				
			}
			if(GUI.Button(new Rect(5,35,90,25), "Attack")) {
				
			}
			if(GUI.Button(new Rect(5,65,90,25), "Kill")) {
				//destroy unit
			}
			GUI.EndGroup();
		}
	}
}
