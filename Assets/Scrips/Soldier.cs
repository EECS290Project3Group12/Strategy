using UnityEngine;
using System.Collections;

public class Soldier : Unit {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Soldier newSoldier(PlayerMaster owner) {
		if(owner.playerNumber == 0) {
			tag = "PlayerOne";
		} else {
			tag = "PlayerTwo";
		}
		cost = 2;
		moveRange = 5;
		attackRange = 1;
		damage = 1;
		team = owner;
		state = true;
		type = unitType.Soldier;
		return this;
	}
}
