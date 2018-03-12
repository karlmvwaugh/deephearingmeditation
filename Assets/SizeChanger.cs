using UnityEngine;
using System.Collections;

public class SizeChanger : MonoBehaviour {
	public Oscillator oscillator; 
	public float initialSize; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var value = oscillator.GetValue();
		var newValue = value * initialSize;

		transform.localScale = new Vector3(newValue, newValue, 1f);
	}
}
