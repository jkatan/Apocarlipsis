using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectionUI : MonoBehaviour {

	private int ind; //0,1,2//

	public int indMultiplier;

	public float lastValue;

	// Use this for initialization
	void Start () {
		ind = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (lastValue == 0 && Input.GetAxis ("Joystick1AxisY") != 0) {

			lastValue = Input.GetAxis ("Joystick1AxisY");
		}



		if (lastValue > 0 && Input.GetAxis ("Joystick1AxisY") == 0 && ind > 0) {

			ind--;
			transform.Translate(0,indMultiplier, 0);
		}

		if (lastValue < 0 && Input.GetAxis ("Joystick1AxisY") == 0 && ind < 2) {

			ind++;
			transform.Translate(0,-indMultiplier, 0);
		}

		if (lastValue != 0 && Input.GetAxis ("Joystick1AxisY") == 0)
			lastValue = 0;


		if (Input.GetButton("PS4XButton") && ind==0){
            GameData.resetData();
			SceneManager.LoadScene ("MainState");
		}

		if (Input.GetButton("PS4XButton") && ind==1){
			SceneManager.LoadScene ("CreditsState");
		}

		if (Input.GetButton("PS4XButton") && ind==2){
			Application.Quit ();
			Debug.Log ("Quit");
		}

	}
}
