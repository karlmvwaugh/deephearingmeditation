using UnityEngine;
using System;
using System.Collections;

public class Oscillator : MonoBehaviour {
	public float max;
	public float min;
	public float speed; //seconds
	
	private float theta;
	private DateTime _lastTime;
	
	private static System.Random random = new System.Random();
	
	private float piThing;
	// Use this for initialization
	void Start () {
		theta = (float)random.NextDouble()*Mathf.PI*2f;
		_lastTime = DateTime.Now;
		piThing = Mathf.PI * 2f / 1000f; 
	}
	
	public float GetValue(){
		return (Mathf.Sin(theta*piThing)*(max - min) + max + min ) / 2f;
	}
	
	// Update is called once per frame
	void Update () {
		var delta = GetDelta();
		theta += frac(delta);
		
		_lastTime = DateTime.Now;
	}

	float frac(float delta) {
		return speed > 0 ? delta / speed : 0;
	}
	
	float GetDelta(){
		var now = DateTime.Now;
		return (float)(now - _lastTime).TotalMilliseconds;
	}
}
