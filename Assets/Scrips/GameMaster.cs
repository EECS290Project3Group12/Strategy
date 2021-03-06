/**
 *Controls the general flow of the entire game
 *Authors: Joseph Satterfield & Charles Marshall
 **/

using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	//An array of all of the "player masters", the objects that handle the individual players
	PlayerMaster[] playerMasters = new PlayerMaster[2];
	
	//An array that would hold all of the spawn points
	public GameObject[] spawnPoints;
	
	//The player who's turn it currently is
	public int currentPlayer = 0;
	
	//Has a player won the game
	bool hasWon = false;
	
	//The next turn button
	public KeyCode nextTurn = KeyCode.Return;
	
	//Timer to stop multiple turns passing in one click
	public float turnRepeatStop = 1.0f;
	
	//The time passed since the last turn
	float timeSinceLastTurn = 0;
	
	public PlayerMaster player;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		playerMasters[0] = (PlayerMaster) Instantiate(player);
		playerMasters[0].newPlayerMaster(0,100);
		playerMasters[1] = (PlayerMaster) Instantiate(player);
		playerMasters[1].newPlayerMaster(1,100);
		int counter = 0;		//Sets a counter for the index of the spawnpoint array
		foreach(PlayerMaster master in playerMasters)
		{
			master.SendMessage ("setSpawnPoint", spawnPoints[counter].transform.position);
			counter+= 1;
		}
		playerMasters[currentPlayer].SendMessage ("SwapUnitStates");
		playerMasters[0].gameObject.SetActive(true);
		playerMasters[1].gameObject.SetActive(false);
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
		playerMasters[currentPlayer].gameObject.SetActive(false);
		if(currentPlayer >= playerMasters.Length - 1)
			currentPlayer = 0;
		else
			currentPlayer += 1;
		//Call the start turn routine on the current player
		playerMasters[currentPlayer].gameObject.SetActive(true);
		playerMasters[currentPlayer].SendMessage ("StartTurn");
		Debug.Log ("It is player turn " + playerMasters[currentPlayer].ToString ());
	}
}
