using UnityEngine;
using System.Collections;

public class VariableandFunctions : MonoBehaviour {

	int myNumber = 5;

	// Use this for initialization
	void Start () {

		myNumber = MultiplyByTwo (myNumber);
		Debug.Log (myNumber);

	}

	int MultiplyByTwo (int number)
	{
		int doubleN;
		doubleN = number * 2;
		return doubleN;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
