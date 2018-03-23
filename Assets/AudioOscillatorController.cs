using UnityEngine;
using System;
using System.Collections;

public class AudioOscillatorController : MonoBehaviour {
	public Oscillator Osc1;
	public Oscillator Osc2;
	public PlusMinusBalance balance0;
	public PlusMinusBalance balance1;
	public PlusMinusBalance balance2;
	public RandomWalk walker;
	public float startTimeSeconds;

	private DateTime startTime;
	private bool started = false; 

	private float share = 0;
	// Use this for initialization
	void Start () {
		balance0.overallValue = 0;
		balance1.overallValue = 0;
		balance2.overallValue = 0;

		startTime = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		if (!started){
			fadeIn();
		}


		var coord = walker.GetCoordinate();
		Osc1.speed = 0.1f + 199.9f * coord.x;
		Osc2.speed = 0.1f + 199.9f * coord.y;

		balance0.overallValue = share;
		balance1.overallValue = share * Osc1.GetValue();
		balance2.overallValue = share * Osc2.GetValue(); 
	}

	void fadeIn(){
		var now = DateTime.Now;
		var dif = (float)(now - startTime).TotalSeconds;
		share = dif / startTimeSeconds;

		if (share >= 1){
			share = 1;
			started = true; 
		}


	}
}
