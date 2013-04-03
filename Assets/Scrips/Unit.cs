using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	public enum unitType {Soldier, Archer, Cannon};
	
	public int cost;
	public int moveRange;
	public int attackRange;
	public int damage;
	public PlayerMaster team;
	public bool state;
	public unitType type;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void FlipState() {
		if(state == true) {
			state = false;
		} else {
			state = true;
		}
	}
}
