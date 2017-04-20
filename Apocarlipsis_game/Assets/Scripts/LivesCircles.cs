using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCircles : MonoBehaviour {
	[SerializeField]
	private int player;
	[SerializeField]
	private GameObject[] circles;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int lives = 0;

		if(player == 1)
			lives = GameData.player1Lives;
		if(player == 2)
			lives = GameData.player2Lives;
		
		if (lives <= 3)
			changeColor(3);
		if (lives <= 2)
			changeColor(2);
		if (lives <= 1)
			changeColor(1);
		if (lives == 0)
			changeColor(0);
	
	}

	void changeColor(int ind){
		circles [ind].GetComponent<Image> ().color = new Color (255,0,0,255);
	}

}

