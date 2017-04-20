using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownBehaviour : MonoBehaviour {

    private Text countdown;

	// Use this for initialization
	void Start () {
        countdown = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.SetActive(!GameData.gameRunning);

        countdown.text = Mathf.Ceil(GameData.gameStartTimer) + "";
    }
}
