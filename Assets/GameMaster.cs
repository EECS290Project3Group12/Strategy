using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	//An array of all of the "player masters", the objects that handle the individual 
	PlayerMaster[] playerMasters = new PlayerMaster[2];
	
	//The player who's turn it currently is
	int currentPlayer = 0;
	
	//Has a player won the game
	bool hasWon = false;
	
	//The next turn button
	public KeyCode nextTurn = KeyCode.Return;
	
	//Timer to stop multiple turns passing in one click
	float turnRepeatStop = 1.0f;
	
	//The time passed since the last turn
	float timeSinceLastTurn = 0;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		playerMasters[0] = new PlayerMaster(0,100);
		playerMasters[1] = new PlayerMaster(1,100);
		
		Debug.Log (playerMasters[currentPlayer].ToString ());
		playerMasters[currentPlayer].SendMessage ("SwapUnitStates");
	}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		if(Input.GetKey (nextTurn) && timeSinceLastTurn > turnRepeatStop)
		{
			NextPlayerTurn ();
			timeSinceLastTurn = 0;
		}
		timeSinceLastTurn += Time.deltaTime;
	}
	
	/// <summary>
	/// Advances the turn to the next player
	/// </summary>
	void NextPlayerTurn () {
		//Call the end turn routine on a player
		playerMasters[currentPlayer].SendMessage ("EndTurn");
		if(currentPlayer >= playerMasters.Length - 1)
			currentPlayer = 0;
		else
			currentPlayer += 1;
		//Call the start turn routine on the current player
		playerMasters[currentPlayer].SendMessage ("StartTurn");
		Debug.Log ("It is player turn " + playerMasters[currentPlayer].ToString ());
	}
}
