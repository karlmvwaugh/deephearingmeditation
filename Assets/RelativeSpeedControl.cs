using UnityEngine;
using System.Collections;

public class RelativeSpeedControl : MonoBehaviour {
	public RandomWalk walker;
	public float overallFactor;
	public float centreSpeed = 0f;
	public float balance = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var coord = walker.GetCoordinate();

		centreSpeed = coord.x * 2f - 1f;
		balance = 1f + coord.y;
	}

	public float GetSpeedBalance(bool positive){
		if (positive){
			return overallFactor * (centreSpeed + 0.5f*balance);
		}
		return overallFactor * (centreSpeed - 0.5f*balance);

	}
}
