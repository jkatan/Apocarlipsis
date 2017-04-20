using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
    
    public Vector2 lookVector = new Vector2(1, 0);

    private void Awake()
    {
        if (gameObject.tag == "Player1")
        {
            GameData.player1 = gameObject;
        }
        else if (gameObject.tag == "Player2")
        {
            GameData.player2 = gameObject;
        }
    }

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        var joyStick = new Vector2(0, 0);
        if (gameObject.tag == "Player1")
        {
            Debug.Log("JOYSTICK1: " + new Vector2(Input.GetAxis("Joystick1Axis3"), Input.GetAxis("Joystick1Axis4")));
            //joyStick = new Vector2(Input.GetAxis("Joystick1Axis3"), Input.GetAxis("Joystick1Axis4"));
			joyStick = new Vector2(Input.GetAxis("PS4RightAnallogic1X"), -Input.GetAxis("PS4RightAnallogic1Y"));

        } else if(gameObject.tag == "Player2")
        {
            Debug.Log("JOYSTICK2: " + new Vector2(Input.GetAxis("Joystick2Axis3"), Input.GetAxis("Joystick2Axis4")));
            //joyStick = new Vector2(Input.GetAxis("Joystick2Axis3"), Input.GetAxis("Joystick2Axis4"));
			joyStick = new Vector2(Input.GetAxis("PS4RightAnallogic2X"), -Input.GetAxis("PS4RightAnallogic2Y"));
        }
        if (joyStick.magnitude > 0)
        {
            lookVector = joyStick;
        }

        //Debug.Log(transform.position);
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector3 worldMousePos = new Vector3(lookVector.x, lookVector.y, 0);
        float angle = Vector2.Angle(
            new Vector2(1, 0),
            new Vector2(worldMousePos.x, worldMousePos.y));
        if (worldMousePos.y < transform.position.y)
        {
            angle += 180;
        }

        //Debug.Log(angle);
        if ((angle > 0 && angle < 45) || (angle > 180 && angle < 225))
        {
            //Debug.Log("Right");
        }
        if(angle > 45 && angle < 135)
        {
            //Debug.Log("Top");
        }
        if((angle > 135 && angle < 180) || (angle > 315 && angle < 360))
        {
            //Debug.Log("Left");
        }
        if(angle < 315 && angle > 235)
        {
            //Debug.Log("Bottom");
        }
	}
}
