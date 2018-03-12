using UnityEngine;
using System.Collections;

public class ControlRandomWalkSpeed : MonoBehaviour {
	public RandomWalk TheWalker;
	public Oscillator TheOscillator;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		TheWalker.maxStepSize = TheOscillator.GetValue();
	}
}
