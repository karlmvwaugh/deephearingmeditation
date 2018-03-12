using UnityEngine;
using System.Collections;

public class PlusMinusBalance : MonoBehaviour {
	public Oscillator oscillator;
	public AudioSource sourceMinus;
	public AudioSource sourcePlus;
	public AudioSource sourceMain;
	public float overallValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var value = oscillator.GetValue();

		if (value < 0){
			sourcePlus.volume = overallValue;
			sourceMinus.volume = overallValue * (1f + value);
		} else {
			sourcePlus.volume = overallValue * (1f - value);
			sourceMinus.volume = overallValue;
		}

		sourceMain.volume = overallValue; 
	}
}
