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
	public int health;
	
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
	
	public int attackOpponent(Unit opponent) {
		if(this.team == opponent.team) {
			return -1;
		} else if(Vector3.Distance(this.transform.position, opponent.transform.position) > attackRange) {
			return -1;
		} else {
			opponent.health -= this.damage;
			if(opponent.health <= 0) {
				Destroy(opponent);
				return 0;
			} else {
				return opponent.health;
			}
		}
	}
}
