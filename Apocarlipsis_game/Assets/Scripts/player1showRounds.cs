using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1showRounds : MonoBehaviour {

    private Text roundsWon;

	// Use this for initialization
	void Start () {

        roundsWon = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        roundsWon.text = "Lives: " + GameData.player1Lives.ToString();
	}
}
