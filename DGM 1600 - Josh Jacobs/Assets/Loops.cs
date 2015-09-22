using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	// number of red balloons for the 'for loop'
	int numRedBalloons = 3;

	// number of blue balloons for the 'while loop'
	int blueBalloons = 4;


	// Use this for initialization
	void Start () {

		// for loop
		for(int i = 0; i < numRedBalloons; i++)
		{
			Debug.Log("Creating Red Balloon number: " + i);
		}


		// while loop
		while(blueBalloons > 0)
		{
			Debug.Log ("There is a blue balloon");
			blueBalloons--;
		}


		// do while loop
		bool shouldContinue = false;
		
		do
		{
			print ("Hello Yellow Balloon!");
			
		}while(shouldContinue == true);


		// foreach loop
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
