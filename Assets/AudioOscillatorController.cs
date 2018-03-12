using UnityEngine;
using System.Collections;

public class AudioOscillatorController : MonoBehaviour {
	public Oscillator Osc1;
	public Oscillator Osc2;
	public PlusMinusBalance balance1;
	public PlusMinusBalance balance2;
	public RandomWalk walker;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var coord = walker.GetCoordinate();
		Osc1.speed = 0.1f + 199.9f * coord.x;
		Osc2.speed = 0.1f + 199.9f * coord.y;

		balance1.overallValue = Osc1.GetValue();
		balance2.overallValue = Osc2.GetValue(); 
	}
}
