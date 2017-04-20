using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateNormal : MonoBehaviour {

    public GameObject normalObject;
    public Vector2 normal;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        normal = transform.position - normalObject.transform.position;
        normal.Normalize();
    }
}
