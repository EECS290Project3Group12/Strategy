using UnityEngine;
using System.Collections;

public class Cannon : Unit {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Cannon newCannon(PlayerMaster owner) {
		if(owner.playerNumber == 0) {
			tag = "PlayerOne";
		} else {
			tag = "PlayerTwo";
		}
		cost = 5;
		moveRange = 2;
		attackRange = 10;
		damage = 5;
		team = owner;
		state = true;
		type = unitType.Cannon;
		health = 10;
		return this;
	}
}
