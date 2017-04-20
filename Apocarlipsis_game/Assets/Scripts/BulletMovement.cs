using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float movementSpeed = 5;
    public float outOfBoundsDistance = 25;
    public Vector2 movementDelta;
    private PlayerLook playerLook;

	// Use this for initialization
	void Start () {
        OnEnable();
    }

    private void OnEnable()
    {
        if (gameObject.tag == "Bullets1")
        {
            playerLook = GameData.player1.GetComponent<PlayerLook>();
        }
        else if (gameObject.tag == "Bullets2")
        {
            playerLook = GameData.player2.GetComponent<PlayerLook>();
        }
        //Vector3 worldMousePos = transform.position + new Vector3(playerLook.lookVector.x, playerLook.lookVector.y, 0);

        //Debug.Log(transform.position);
        //Debug.Log(worldMousePos);
        //movementDelta = new Vector2(worldMousePos.x, worldMousePos.y) - new Vector2(transform.position.x, transform.position.y);
        //Debug.Log(movementDelta);
        movementDelta = playerLook.lookVector;
        movementDelta.Normalize();
    }

    // Update is called once per frame
    void Update () {
        transform.position = transform.position + new Vector3(movementDelta.x, movementDelta.y, 0) * movementSpeed * Time.deltaTime;

        if(Vector3.Distance(transform.position, new Vector3(0, 0, 0)) > outOfBoundsDistance)
        {
            gameObject.SetActive(false);
        }
	}

}
