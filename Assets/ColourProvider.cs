using UnityEngine;
using System.Collections;

public class ColourProvider : MonoBehaviour {
	public RandomWalk walker; 
	public Oscillator colourOscillator;
	private Color color1;
	private Color color2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var coord = walker.GetCoordinate();
		var red = colourOscillator.GetValue();
		color1 = new Color(red, coord.x, coord.y);
		color2 = new Color(red, 1f - coord.x, 1f - coord.y);
	}

	public Color GetColour1() {
		return color1;
	}

	public Color GetColour2() {
		return color2;
	}
}
