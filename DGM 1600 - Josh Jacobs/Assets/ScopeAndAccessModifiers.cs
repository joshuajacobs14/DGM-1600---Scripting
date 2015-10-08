using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour {

	public int alpha = 5;
	public int donuts = 12;
	private int muffins = 6;
	private int danish = 3;


	private SecondScript otherClass;


	void start ()
	{
		alpha = 29;

		otherClass = new SecondScript();
		otherClass.FruitCounter(alpha, otherClass.cherry);
		
	}


	void Example (int cakes, int fritters)
	{
		int answer;
		answer = cakes * fritters * alpha;
		Debug.Log (answer);
	}


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			alpha += muffins;
			alpha += danish;
		}


		Debug.Log ("Alpha is set to: " + alpha);


	}
	/*
	void countPastries() 
	{
		int pastries = donuts + muffins;
		
		Debug.Log ("There are " + donuts + 
		           " donuts and " + muffins + " muffins.");
		Debug.Log("There are " + pastries + " pastries total");
	
	}
	*/


}
