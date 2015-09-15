using UnityEngine;
using System.Collections;

public class VariableandFunctions : MonoBehaviour {
	
	int myNumber = 5;
	
	// Use this for initialization
	void Start () {
		
		myNumber = DivideByTwo (myNumber);
		Debug.Log (myNumber);
		
	}
	
	int DivideByTwo (int number)
	{
		int doubleN;
		doubleN = number / 2;
		return doubleN;
	}
}
