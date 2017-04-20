using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLook : MonoBehaviour {

    Vector3 lastPosition;
    BulletMovement bulletMovement;

	// Use this for initialization
	void Start () {
        bulletMovement = transform.parent.GetComponent<BulletMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 delta = transform.position - lastPosition;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg - 90));
        lastPosition = transform.position * 1;
    }
}
