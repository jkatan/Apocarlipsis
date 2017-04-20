using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundStart : MonoBehaviour {

    Text roundText;

	// Use this for initialization
	void Start () {
        roundText = GetComponent<Text>();
        roundText.text = "Round " + GameData.gameRound;
	}
	
	// Update is called once per frame
	void Update () {

        if (GameData.gameRunning)
            gameObject.SetActive(false);
	}
}
