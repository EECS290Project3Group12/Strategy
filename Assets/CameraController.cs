using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	//The key that makes the camera go left
	public KeyCode leftKey = KeyCode.LeftArrow;
	
	//The key that makes the camera go right
	public KeyCode rightKey = KeyCode.RightArrow;
	
	//The key that makes the camera go forward
	public KeyCode forwardKey = KeyCode.UpArrow;
	
	//The key that makes the camera go backwards
	public KeyCode backKey = KeyCode.DownArrow;
	
	//Multiplies the speed of the camera
	public float speedMultiplier = 5.0f;
	
	//Multiplier for mouse scroll
	public float mouseSpeedMultiplier = 0.75f;
	
	//Bouning area for mouse scroll
	public float mouseScrollBound = .05f;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
	
	}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		//Key scroll
		if(Input.GetKey (forwardKey))
		{
			transform.Translate (Vector3.forward * (Time.deltaTime * speedMultiplier),Space.World);
		}
		
		if(Input.GetKey (backKey))
		{
			transform.Translate (- Vector3.forward * (Time.deltaTime * speedMultiplier) ,Space.World);
		}
		
		if(Input.GetKey (leftKey))
		{
			transform.Translate (- Vector3.right * (Time.deltaTime * speedMultiplier) ,Space.World);
		}
		
		if(Input.GetKey (rightKey))
		{
			transform.Translate ( Vector3.right * (Time.deltaTime * speedMultiplier) ,Space.World);
		}
		//Mouse scroll
		if(Input.mousePosition.x < Screen.width* mouseScrollBound)
		{
			transform.Translate (- Vector3.right * (Time.deltaTime * speedMultiplier * mouseSpeedMultiplier) ,Space.World);
		}
		
		if(Input.mousePosition.x > Screen.width* (1 - mouseScrollBound))
		{
			transform.Translate ( Vector3.right * (Time.deltaTime * speedMultiplier * mouseSpeedMultiplier) ,Space.World);
		}
		
		if(Screen.height - Input.mousePosition.y < Screen.height* mouseScrollBound)
		{
			transform.Translate ( Vector3.forward * (Time.deltaTime * speedMultiplier * mouseSpeedMultiplier) ,Space.World);
		}
		
		if(Screen.height - Input.mousePosition.y > Screen.height* (1 - mouseScrollBound))
		{
			transform.Translate ( - Vector3.forward * (Time.deltaTime * speedMultiplier * mouseSpeedMultiplier) ,Space.World);
		}
	}
}
