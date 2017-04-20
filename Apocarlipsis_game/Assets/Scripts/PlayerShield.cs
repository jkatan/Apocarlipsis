using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    private PlayerLook playerLook;
    public float cooldownTime;
    public float shieldTime;
    private float delayTime=0;
    private bool shieldActivated=false;
    public GameObject shieldContainer;
    public GameObject shieldObject;
    public int player = 0;
    private bool shieldCooldown=false;

    // Use this for initialization
    void Start () {
        shieldObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.tag == "Player1")
        {
            GameData.player1ShieldTime = delayTime;
        }
        else if (gameObject.tag == "Player2")
        {
            GameData.player2ShieldTime = delayTime;
        }

        if (!shieldCooldown)
        {
            if (gameObject.tag == "Player1")
            {
                playerLook = GameData.player1.GetComponent<PlayerLook>();
            }
            else if (gameObject.tag == "Player2")
            {
                playerLook = GameData.player2.GetComponent<PlayerLook>();
            }

            Vector3 delta = playerLook.lookVector;
            shieldContainer.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg));
            if (player == 1)
            {
                if ((Input.GetKey(KeyCode.Comma) || Input.GetButton("Joystick1Shield")) && (!shieldActivated))
                {
                    shieldObject.SetActive(true);
                    shieldActivated = true;
                    delayTime = shieldTime;
                }
            }
            if (player == 2)
            {
                if ((Input.GetKey(KeyCode.V) || Input.GetButton("Joystick2Shield")) && (!shieldActivated))
                {
                    shieldObject.SetActive(true);
                    shieldActivated = true;
                    delayTime = shieldTime;
                }
            }
            if (shieldActivated)
            {
                delayTime -= Time.deltaTime;
                if (delayTime <= 0)
                {
                    shieldActivated = false;
                    shieldObject.SetActive(false);
                    shieldCooldown = true;
                    delayTime = cooldownTime;
                    if (gameObject.tag == "Player1")
                    {
                        playerLook = GameData.player1.GetComponent<PlayerLook>();
                    }
                    else if (gameObject.tag == "Player2")
                    {
                        playerLook = GameData.player2.GetComponent<PlayerLook>();
                    }
                }
            }
        }
        else
        {
            delayTime -= Time.deltaTime;
            if (delayTime <= 0)
            {
                shieldCooldown = false;
                delayTime = cooldownTime;
            }
        }
    }
}
