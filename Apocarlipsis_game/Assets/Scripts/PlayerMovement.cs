using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float translateSpeed;
    public int player = 0;

	public Animator playerAnim;
    public GameObject playerObject;
    public PlayerLook playerLook;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        float speed = translateSpeed * Time.deltaTime;
        if (player == 1)
        {

			Vector3 movement1 = new Vector3(Input.GetAxis("Joystick1AxisX") * speed, Input.GetAxis("Joystick1AxisY") * speed, 0);
            //Debug.Log("JOYSTICK1: " + new Vector2(Input.GetAxis("Joystick1AxisX"), Input.GetAxis("Joystick1AxisY")));
			transform.Translate(movement1);

			Vector3 scale1 = playerObject.transform.localScale;

			if (playerLook.lookVector.x < 0)
				scale1.x = -1;
			else
				scale1.x = 1;

            playerObject.transform.localScale = scale1;

			if (movement1.magnitude > 0)
				playerAnim.SetBool ("Walk", true);
			else {
				playerAnim.SetBool ("Walk", false);
			}

            if (Input.GetKey("right"))
                transform.Translate(translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey("left"))
                transform.Translate(-translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey("up"))
                transform.Translate(0, translateSpeed * Time.deltaTime, 0);

            if (Input.GetKey("down"))
                transform.Translate(0, -translateSpeed * Time.deltaTime, 0);
    } else
        {
			Vector3 movement2 = new Vector3(Input.GetAxis("Joystick2AxisX") * speed, Input.GetAxis("Joystick2AxisY") * speed, 0);
            //Debug.Log("JOYSTICK2: " + new Vector2(Input.GetAxis("Joystick2AxisX"), Input.GetAxis("Joystick2AxisY")));
			transform.Translate(movement2);

            Vector3 scale1 = playerObject.transform.localScale;

            if (playerLook.lookVector.x < 0)
                scale1.x = -1;
            else
                scale1.x = 1;

            playerObject.transform.localScale = scale1;

            if (movement2.magnitude > 0.05f)
				playerAnim.SetBool ("Walk", true);
			else {
				playerAnim.SetBool ("Walk", false);
			}

			Debug.Log (movement2.magnitude);

            if (Input.GetKey(KeyCode.D))
                transform.Translate(translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.A))
                transform.Translate(-translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.W))
                transform.Translate(0, translateSpeed * Time.deltaTime, 0);

            if (Input.GetKey(KeyCode.S))
                transform.Translate(0, -translateSpeed * Time.deltaTime, 0);
        }
    }
}
