using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public float weight = 185.0f;
	public float underWeight = 105.0f;
	public float overWeight = 155.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Space))
			WeightTest();
		
		weight -= Time.deltaTime * 5f;

	}
	void WeightTest ()
	{
		// If the weight is higher than overWeight...
		if(weight > overWeight)
		{
			// ... do this.
			print("Overweight. Lose weight.");
		}
		// If it isn't, but weight is lower than underWeight...
		else if(weight < underWeight)
		{
			// ... do this.
			print("Underweight. Too skinny. Eat more");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("Healthy Balance");
		}
	}
}
