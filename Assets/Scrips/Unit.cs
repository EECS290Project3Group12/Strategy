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
	//public GameObject gui;
	
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
	
	public GameObject findClosestEnemy() {
		GameObject[] enemies;
		if(team.playerNumber == 0) {
			enemies = GameObject.FindGameObjectsWithTag("PlayerTwo");
		} else {
			enemies = GameObject.FindGameObjectsWithTag("PlayerOne");
		}
		
		GameObject closest = enemies[0];
		float closestDist = Mathf.Infinity;
		float dist;
		
		foreach(GameObject u in enemies) {
			dist = (transform.position - u.transform.position).sqrMagnitude;
			if(dist < closestDist) {
				closestDist = dist;
				closest = u;
			}
		}
		return closest;
	}
	
	/*public int attackOpponent(GameObject opponent) {
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
	}*/
	
	public void killSelf() {
		team.currentUnitPoints += cost;
		Destroy(gameObject);
	}
	
	void OnMouseDown()
	{
		//gui.SendMessage ("SetUnitHealth", health);
		//gui.SendMessage ("SetAttackDamage", damage);
	}
	
	
}
