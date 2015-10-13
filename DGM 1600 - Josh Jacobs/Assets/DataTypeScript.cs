using UnityEngine;
using System.Collections;

public class DataTypeScript : MonoBehaviour {

	//public fruit = ClassesScript1 banana;
	
	public int banana = 3;
	public float potato = 4.3f;
	public double temperature = 105.434;
	public bool hot = true;
	public char firstLetter = 'j';

	/*Value Types:
	 * int
	 * float
	 * double
	 * bool
	 * char
	 */

	/*Reference Types:
	 * Transform
	 * GameObject
	 */ 

	void Start () 
	{
		Transform control = transform;
		control.position = new Vector3 (0, 2, 0);

		Debug.Log ("bananas: " + banana + "\npotatoes: " + 
		           potato + "\ntemperature: " + temperature +
		           "\nhot? " + hot + "\nletter: " + firstLetter);
		           

	}

	// Update is called once per frame

	/*
	void Update () {
	
	}
	*/
}
