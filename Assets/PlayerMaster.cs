using UnityEngine;
using System;
using System.Collections;

public class PlayerMaster : MonoBehaviour {
	
	//The current gold of the player
	int currentGold;
	
	//The starting gold of the player
	public int startingGold;
	
	//All of the units that player has
	Unit[] units = new Unit[10];
	
	//The maximum unit point the player can has
	public int maxUnitPoints = 20;
	
	//The current unit points a player has
	int currentUnitPoints = 0;
	
	//The player number. This is really hacky, but we need something for tomorrow, I'll fix it, I swear
	public int playerNumber;
	
	public PlayerMaster newPlayerMaster(int number, int gold) {
		playerNumber = number;
		startingGold = gold;
		currentGold = startingGold;
	}
	
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
	
	/// <summary>
	/// Changes the amount of gold a player has gold.
	/// </summary>
	/// <param name='gold'>
	/// Gold.
	/// </param>
	void changeGold(int gold)
	{
		currentGold = gold;
	}
	
	/// <summary>
	/// Swaps the unit states. Activates if deactivated, deactivates if activated.
	/// </summary>
	void SwapUnitStates()
	{
		foreach(Unit g in units)
			g.FlipState();
	}
	
	/// <summary>
	/// Starts the player's turn.
	/// </summary>
	void StartTurn()
	{
		SwapUnitStates();
	}
	
	/// <summary>
	/// Ends the player's turn.
	/// </summary>
	void EndTurn()
	{
		SwapUnitStates();
	}
	
	void SpawnUnit(string type)
	{
		int openIndex = Array.FindIndex(units, i => i == null);
		if(openIndex == -1) {
			return;
		} else {
			switch(type) {
			case "soldier":
				units[openIndex] = new Soldier(this);
				currentUnitPoints -= units[openIndex].cost;
				break;
			}
		}
	}
}
