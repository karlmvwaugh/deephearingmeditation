using UnityEngine;
using System.Collections;

public class RandomWalk : MonoBehaviour {
	public string debugText;

	private System.Random random = new System.Random();
	private Vector2 coordinate;

	public float maxStepSize = 0.005f;
	private bool evenStep = true;
	private string debugMouse = "";
	// Use this for initialization
	void Start () {
		coordinate = new Vector2((float)random.NextDouble(), (float)random.NextDouble()); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var dif = getRandom();
		if (evenStep){
			coordinate.x  = limit(coordinate.x  + dif);
		} else {
			coordinate.y = limit(coordinate.y + dif);
		}
		evenStep = ! evenStep;

		debugText = coordinate.x + ", " + coordinate.y + " / " + debugMouse; 

	}

	private float getRandom() {
		if (IsTouch()){
			debugMouse = touchCoordinate.x + " & " + touchCoordinate.y;
			bool positive; 
			if (evenStep){
				positive = (touchCoordinate.x >= coordinate.x);
			
			} else {
				positive = (touchCoordinate.y >= coordinate.y);
			}

			return (positive ? 1 : -1) * (float)random.NextDouble() * 2 * maxStepSize;


		} else {
			debugMouse = "";
			return (float)random.NextDouble() * 2 * maxStepSize - maxStepSize;
		}
	}

	private float limit(float value) {
		if (value > 1f){
			return limit (value - 1f);
		} 

		if (value < 0f){
			return limit (value + 1f);
		}

		return value; 
	}

	public Vector2 GetCoordinate(){
		return coordinate;
	}

	private Vector2 touchCoordinate;

	private bool IsTouch(){
		var isMouse = isMouseTouch();
		if (isMouse) return isMouse; 
		
		return isPhoneTouch(); 
	}
	
	private bool isMouseTouch(){		
		if (Input.GetMouseButton(0)){
			touchCoordinate = Input.mousePosition;
			touchCoordinate.x /= Screen.width;
			touchCoordinate.y /= Screen.height;
			return true;
		}
		
		return false; 
	}
	
	private bool isPhoneTouch(){
		if (Input.touchCount > 0) {
			Touch tou = Input.GetTouch(0);
			touchCoordinate = tou.position;
			touchCoordinate.x /= Screen.width;
			touchCoordinate.y /= Screen.height;
			return true;
		}
		
		return false;
	}



}
