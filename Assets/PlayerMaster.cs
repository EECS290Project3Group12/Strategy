using UnityEngine;
using System.Collections;

public class PlayerMaster : MonoBehaviour {
	
	//The current gold of the player
	int currentGold = 0;
	
	//The starting gold of the player
	public int startingGold = 100;
	
	//All of the units that player has
	GameObject[] units;
	
	//The maximum unit point the player can has
	public int maxUnitPoints = 20;
	
	//The current unit points a player has
	int currentUnitPoints = 0;
	
	//The player number. This is really hacky, but we need something for tomorrow, I'll fix it, I swear
	public int playerNumber = 0;
	
	
	// Use this for initialization
	void Start () {
		if(playerNumber == 0)
			units = GameObject.FindGameObjectsWithTag ("BlueUnit");
		else
			units = GameObject.FindGameObjectsWithTag ("RedUnit");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	/// <summary>
	/// Changes the amount of gold a player has gold.
	/// </summary>
	/// <param name='gold'>
	/// Gold.
	/// </param>
	void changeGold (int gold)
	{
		
	}
	
	/// <summary>
	/// Swaps the unit states. Activates if deactivated, deactivates if activated.
	/// </summary>
	void SwapUnitStates()
	{
		foreach(GameObject g in units)
			//Swap the unit states Later, for now, just print units
			Debug.Log (g.ToString ());
	}
	
	/// <summary>
	/// Starts the player's turn.
	/// </summary>
	void StartTurn()
	{
		SwapUnitStates ();
	}
	
	/// <summary>
	/// Ends the player's turn.
	/// </summary>
	void EndTurn()
	{
		SwapUnitStates ();
	}
}