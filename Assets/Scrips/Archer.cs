using UnityEngine;
using System.Collections;

public class Archer : Unit {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Archer newArcher(PlayerMaster owner) {
		if(owner.playerNumber == 0) {
			tag = "PlayerOne";
		} else {
			tag = "PlayerTwo";
		}
		cost = 3;
		moveRange = 3;
		attackRange = 5;
		damage = 3;
		team = owner;
		state = true;
		type = unitType.Archer;
		return this;
	}
}
