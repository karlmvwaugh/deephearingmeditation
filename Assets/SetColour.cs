using UnityEngine;
using System.Collections;

public class SetColour : MonoBehaviour {
	public ColourProvider colourProvider;
	public bool MainColour; 
	private SpriteRenderer renderer;
	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (MainColour){
			renderer.color = colourProvider.GetColour1();
		} else {
			renderer.color = colourProvider.GetColour2();
		}
	}
}
