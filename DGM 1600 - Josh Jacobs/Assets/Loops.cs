using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	// number of red balloons for the 'for loop'
	public int numRedBalloons = 3;

	// number of blue balloons for the 'while loop'
	public int blueBalloons = 4;


	// Use this for initialization
	void Start () {

		// for loop - Create 3 Red Balloons
		for(int i = 0; i < numRedBalloons; i++)
		{
			Debug.Log("Creating Red Balloon number: " + i);
		}


		// while loop - Say "There is a balloon" four times
		while(blueBalloons > 0)
		{
			Debug.Log ("There is a blue balloon");
			blueBalloons--;
		}


		// do while loop - print once: "Hello Yellow Balloon"
		bool shouldContinue = false;
		
		do
		{
			print ("Hello Yellow Balloon!");
			
		}while(shouldContinue == true);


		// foreach loop - For each element, print the corresponding string
		string[] balloons = new string[3];
		
		balloons[0] = "I'm a green balloon";
		balloons[1] = "I'm an orange balloon";
		balloons[2] = "I'm a purple balloon";
		
		foreach(string color in balloons)
		{
			print (color);
		}


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
