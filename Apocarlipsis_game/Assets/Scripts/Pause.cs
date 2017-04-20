using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	private bool pause;

	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		Time.timeScale = 0;

		/*

		if(Input.GetButtonDown("Pause") || Input.GetButtonDown("Pause2") || Input.GetKey("space"))
		{
			if(pause == false){
			Time.timeScale = 0;
				pause = true;
			}
			else{
				Time.timeScale = 1;
				pause = false;
			}
		}*/
	}

	public void setPause(){
		pause = false;
	}

}
