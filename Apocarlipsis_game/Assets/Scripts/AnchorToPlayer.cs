﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorToPlayer : MonoBehaviour {

    public GameObject player;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
	}
}
