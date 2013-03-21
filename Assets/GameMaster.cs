using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	//An array of all of the "player masters", the objects that handle the individual 
	GameObject[] playerMasters;
	
	//The player who's turn it currently is
	int currentPlayer = 0;
	
	//Has a player won the game
	bool hasWon = false;
	
	//The next turn button
	public KeyCode nextTurn = KeyCode.Return;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		playerMasters = GameObject.FindGameObjectsWithTag ("PlayerMaster");
		foreach (GameObject p in playerMasters)
		{
			//Call the initialiaization routine for the players
			//For now, just set player 0's units to active
			
		}
		playerMasters[0].SendMessage ("SwapUnitStates");
	}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		if(Input.GetKey (nextTurn))
		{
			NextPlayerTurn ();
		}
	}
	
	/// <summary>
	/// Advances the turn to the next player
	/// </summary>
	void NextPlayerTurn () {
		//Call the end turn routine on a player
		playerMasters[currentPlayer].SendMessage ("EndTurn");
		if(currentPlayer >= playerMasters.Length)
			currentPlayer = 0;
		else
			currentPlayer += 1;
		//Call the start turn routine on the current player
		playerMasters[currentPlayer].SendMessage ("StartTurn");
	}
}
