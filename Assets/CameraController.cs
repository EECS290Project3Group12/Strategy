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
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
	
	}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
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
	}
}
