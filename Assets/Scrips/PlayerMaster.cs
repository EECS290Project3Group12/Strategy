/**
 * Controls the actions of each invidiual team
 * Authors: Joseph Satterfield & Charles Marshall
 **/

using UnityEngine;
using System;
using System.Collections;

public class PlayerMaster : MonoBehaviour {
	
	//The current gold of the player
	public int currentGold;
	
	//The starting gold of the player
	public int startingGold;
	
	//The point that units will spawn around
	public Vector3 unitSpawn;
	
	//All of the units that player has
	Unit[] units = new Unit[10];
	
	Soldier[] soldiers = new Soldier[10];
	
	Archer[] archers = new Archer[6];
	
	Cannon[] cannons = new Cannon[4];
	//The maximum unit point the player can has
	public int maxUnitPoints = 20;
	
	//The current unit points a player has
	public int currentUnitPoints;
	
	//The player number. This is really hacky, but we need something for tomorrow, I'll fix it, I swear
	public int playerNumber;
	
	//The object containing the GUI
	public GameObject gui;
	
	//The amount of unit points that will be slowly added
	public int unitPointTrickle = 0;
	
	public PlayerMaster newPlayerMaster(int number, int gold) {
		playerNumber = number;
		startingGold = gold;
		currentGold = startingGold;
		currentUnitPoints = maxUnitPoints;
		gui=GameObject.Find("GUI");
		gui.SendMessage ("setGold", currentGold);
		gui.SendMessage ("setUnitPoints", currentUnitPoints);
		gui.SendMessage("TurnUIOn");
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
				if(currentUnitPoints < 2) {
					return;
				} else {
					soldiers[openIndex] = (Soldier) Instantiate(soldier);
					soldiers[openIndex].newSoldier(this);
					Vector3 position = new Vector3(unitSpawn.x + UnityEngine.Random.Range (-10, 10),
						unitSpawn.y, unitSpawn.z + UnityEngine.Random.Range (-10,10));
					soldiers[openIndex].transform.position = position;
					currentUnitPoints -= soldiers[openIndex].cost;
				}
				break;
			case "archer":
				if(currentUnitPoints < 3) {
					return;
				} else {
					archers[openIndex] = (Archer) Instantiate(archer);
					archers[openIndex].newArcher(this);
					Vector3 positionA = new Vector3(unitSpawn.x + UnityEngine.Random.Range (-10, 10),
						unitSpawn.y, unitSpawn.z + UnityEngine.Random.Range (-10,10));
					archers[openIndex].transform.position = positionA;
					currentUnitPoints -= archers[openIndex].cost;
				}
				break;
			case "cannon":
				if(currentUnitPoints < 5) {
					return;
				} else {
					cannons[openIndex] = (Cannon) Instantiate(cannon);
					cannons[openIndex].newCannon(this);
					Vector3 positionC = new Vector3(unitSpawn.x + UnityEngine.Random.Range (-10, 10),
						unitSpawn.y, unitSpawn.z + UnityEngine.Random.Range (-10,10));
					cannons[openIndex].transform.position = positionC;
					currentUnitPoints -= cannons[openIndex].cost;
				}
				break;
			}
			gui.SendMessage ("setUnitPoints", currentUnitPoints);
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
		GUI.BeginGroup(new Rect(0, 0, 110, 80));
		
		if(GUI.Button(new Rect(5,5,100,20), "Spawn Soldier")) {
			SpawnUnit("soldier");
		}
		if(GUI.Button(new Rect(5,30,100,20), "Spawn Archer")) {
			SpawnUnit("archer");
		}
		if(GUI.Button(new Rect(5,55,100,20), "Spawn Cannon")) {
			SpawnUnit("cannon");
		}
		GUI.EndGroup();
		GUI.BeginGroup (new Rect(5,75,110,50));
		GUI.Label (new Rect(0,5,100, 20),"Gold: " + currentGold);
		GUI.Label(new Rect(0,30,100, 20),"Unit Point: " + currentUnitPoints);
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
		gui.SendMessage ("setGold", currentGold);
	}
	
	/// <summary>
	/// Swaps the unit states. Activates if deactivated, deactivates if activated.
	/// </summary>
	void SwapUnitStates()
	{
		if(units[0])
		{
			foreach(Unit g in units) {
				g.FlipState();
			}
		}
	}
	
	/// <summary>
	/// Starts the player's turn.
	/// </summary>
	void StartTurn()
	{
		SwapUnitStates();
		gui.SendMessage ("setGold", currentGold);
		gui.SendMessage ("setUnitPoints", currentUnitPoints);
		if(currentUnitPoints < 20 && unitPointTrickle > 0)
			currentUnitPoints+=1;
	}
	
	/// <summary>
	/// Ends the player's turn.
	/// </summary>
	void EndTurn()
	{
		SwapUnitStates();
	}
	
	/// <summary>
	/// Sets the spawn point for units.
	/// </summary>
	/// <param name='spawnPoint'>
	/// The place around where units spawn.
	/// </param>
	void setSpawnPoint(Vector3 spawnPoint)
	{
		unitSpawn = spawnPoint;
	}
	
	
}
