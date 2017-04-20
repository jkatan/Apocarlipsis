using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScrips : MonoBehaviour {

	public int player;
	public Image content;
	private float fill;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(player == 1)
			fill = GameData.player1Health;
		if(player == 2)
			fill = GameData.player2Health;
		Vector3 scale = content.rectTransform.localScale;
		scale.x = map(fill,0,GameData.healthMax,0,1);
		content.rectTransform.localScale = scale;
	}

	private float map(float value, float inMin, float inMax, float outMin, float outMax)
	{
		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
