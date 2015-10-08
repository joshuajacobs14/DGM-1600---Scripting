using UnityEngine;
using System.Collections;

public class SecondScript : MonoBehaviour {

	public int cherry;
	public int grapes;

	private int carrot;
	private int pumpkin;


	public void FruitCounter (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("There are " + answer + " fruit.");
	}

	public void VeggieCounter (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("There are " + answer + " veggies.");
	}
	
}