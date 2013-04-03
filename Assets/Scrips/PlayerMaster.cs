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
	
	Soldier[] soldiers = new Soldier[10];
	
	Archer[] archers = new Archer[6];
	
	Cannon[] cannons = new Cannon[4];
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
		return this;
	}
	
	public Soldier soldier;
	public Archer archer;
	public Cannon cannon;
	
	void SpawnUnit(string type)
	{
		int openIndex = Array.FindIndex(units, i => i == null);
		if(openIndex == -1) {
			return;
		} else {
			switch(type) {
			case "soldier":
				soldiers[openIndex] = (Soldier) Instantiate(soldier);
				soldiers[openIndex].newSoldier(this);
				break;
			case "archer":
				archers[openIndex] = (Archer) Instantiate(archer);
				archers[openIndex].newArcher(this);
				break;
			case "cannon":
				cannons[openIndex] = (Cannon) Instantiate(cannon);
				cannons[openIndex].newCannon(this);
				break;
			}
		}
	}
	
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
	
	void OnGUI() {
		GUI.BeginGroup(new Rect(0, 0, 100, 300));
		
		if(GUI.Button(new Rect(10,10,80,80), "Spawn Soldier")) {
			SpawnUnit("soldier");
		}
		if(GUI.Button(new Rect(10,110,80,80), "Spawn Archer")) {
			SpawnUnit("archer");
		}
		if(GUI.Button(new Rect(10,210,80,80), "Spawn Cannon")) {
			SpawnUnit("cannon");
		}
		
		GUI.EndGroup();
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
		foreach(Unit g in units) {
			g.FlipState();
		}
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
}
