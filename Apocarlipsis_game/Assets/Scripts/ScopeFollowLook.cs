using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeFollowLook : MonoBehaviour {

    public PlayerLook playerLook;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 vector = playerLook.lookVector.normalized;
        transform.position = playerLook.gameObject.transform.position + new Vector3(vector.x, vector.y, 0) * 2;
    }
}
