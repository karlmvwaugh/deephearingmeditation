using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {
	public float rotation; 
	public RelativeSpeedControl speedControl;
	public bool clockwise;
	private float realRotation;
	// Use this for initialization
	void Start () {
		realRotation = rotation;
	}
	
	// Update is called once per frame
	void Update () {
		updateRotation();
		transform.Rotate (Vector3.forward * realRotation); //rotate at steady speed. 
	}

	void updateRotation(){
		var factor = speedControl.GetSpeedBalance(clockwise);

		realRotation = rotation * factor; 

	}
}
