using UnityEngine;
using System.Collections;

public class PanControl : MonoBehaviour {
	public AudioSource audio; 
	public Oscillator mainOsc;
	public Oscillator widthOsc;
	public Oscillator speedOsc;
	public RandomWalk walker; 
	public float bigFactor;
	public float smallFactor;
	public string debug = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var coord = walker.GetCoordinate(); //0-1

		widthOsc.speed = smallFactor + coord.x * bigFactor;
		speedOsc.speed = smallFactor + coord.y * bigFactor;

		mainOsc.speed = speedOsc.GetValue();
		mainOsc.max = widthOsc.GetValue();
		mainOsc.min = -1f * widthOsc.GetValue(); 
		audio.pan = mainOsc.GetValue(); 
		debug = audio.pan.ToString(); 
	}
}
