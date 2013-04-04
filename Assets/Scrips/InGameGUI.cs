using UnityEngine;
using System.Collections;

public class InGameGUI : MonoBehaviour {
	
	//The amount of gold of the current player
	int gold = 0;
	
	//The amount of unit points of the current player
	int unitPoints = 0;
	
	//The selected units type
	string unitName;
	
	//The health of the unit
	int unitHealth;
	
	//The attack damage of the unit
	int attackDamage;
	
	//A picture of the unit
	public Texture unitPicture;
	
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
	
	void OnGUI()
	{
		GUI.BeginGroup (new Rect(0,0,Screen.width,Screen.height*.1f));
		GUI.Label (new Rect(0,0,Screen.width*.2f, Screen.height*.1f),"Gold: " + gold);
		GUI.EndGroup();
	}
	
}
