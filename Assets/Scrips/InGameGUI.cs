using UnityEngine;
using System.Collections;

public class InGameGUI : MonoBehaviour {
	
	//The amount of gold of the current player
	int gold;
	
	//The amount of unit points of the current player
	int unitPoints;
	
	//The selected units type
	string unitName = "";
	
	//The health of the unit
	int unitHealth = 0;
	
	//The attack damage of the unit
	int attackDamage= 0;
	
	//Is the UI on?
	bool isUIOn = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	/// <summary>
	/// Sets the gold.
	/// </summary>
	/// <param name='goldValue'>
	/// The new amount of gold
	/// </param>
	void setGold(int goldValue)
	{
		gold = goldValue;
	}
	
	/// <summary>
	/// Sets the unit points.
	/// </summary>
	/// <param name='unitPointsNow'>
	/// The new amount of unit points
	/// </param>
	void setUnitPoints(int unitPointsNow)
	{
		unitPoints = unitPointsNow;
	}
	
	/// <summary>
	/// Sets the name of the selected unit.
	/// </summary>
	/// <param name='name'>
	/// The unit's name
	/// </param>
	void SetUnitName(string name)
	{
		unitName=name;
	}
	
	/// <summary>
	/// Sets the selected unit's health.
	/// </summary>
	/// <param name='health'>
	/// Health of the unit.
	/// </param>
	void SetUnitHealth(int health)
	{
		unitHealth=health;
	}
	
	/// <summary>
	/// Sets the attack damage attribute of the current unit in the gui.
	/// </summary>
	/// <param name='damage'>
	/// The selected unit's attack damage.
	/// </param>
	void SetAttackDamage(int damage)
	{
		attackDamage=damage;
	}
	
	void OnGUI()
	{
<<<<<<< HEAD
		
=======
		if(isUIOn){
			//Top Bar for team stats
			GUI.BeginGroup (new Rect(0,0,Screen.width,Screen.height*.1f));
			GUI.Label (new Rect(Screen.width/2-100,0,100, Screen.height*.1f),"Gold: " + gold);
			GUI.Label (new Rect(Screen.width/2,0,100,Screen.height*.1f), "Unit Points: "+ unitPoints);
			GUI.EndGroup();
			
			//Bottom bar for unit stats
			GUI.Label (new Rect(Screen.width-100,10,99,20), unitName);
			GUI.Label (new Rect(Screen.width-100, 30,99,20), "Health: "+unitHealth);
			GUI.Label (new Rect(Screen.width-100, 50,99,20), "Strength: "+attackDamage);
		}
	}
	
	/// <summary>
	/// Turns the user interface on.
	/// </summary>
	void TurnUIOn()
	{
		isUIOn = true;
>>>>>>> 4675192ad4c892f62b570a7cdb320a96a8864cdc
	}
	
}
