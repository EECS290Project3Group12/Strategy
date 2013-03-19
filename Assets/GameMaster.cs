using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	//The number of players in the game
	public int numberOfPlayers = 2;
	
	//An array of all of the "player masters", the objects that handle the individual 
	GameObject[] playerMasters;
	
	//The player who's turn it currently is
	int currentPlayer = 0;
	
	//Has a player won the game
	bool hasWon = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
