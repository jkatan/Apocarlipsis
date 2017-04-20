using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour {

	private Text showTime;

	// Use this for initialization
	void Start () {

		showTime = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		GameData.time += Time.deltaTime;
		showTime.text = "Time " + GameData.time.ToString ();
	}
}
