using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    BulletMovement bulletMovement;
    public int collisionHits = 4;
    [HideInInspector]
    public int hitCounter = 0;
    private bool hasHitted = false;

	// Use this for initialization
	void Start () {
        bulletMovement = GetComponent<BulletMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        hasHitted = false;
    }

    public void ResetHits()
    {
        hitCounter = 0;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(!hasHitted) {
            if(collision.gameObject.tag == "Walls") {
                reflectCollision(collision);
            }

            if (this.gameObject.tag == "Bullets1")
            {
                if (collision.gameObject.tag == "Shield2" || ((collision.gameObject.tag == "Shield1") && (hitCounter != 0)))
                {
                    reflectCollision(collision);
                }
            }
            if (this.gameObject.tag == "Bullets2")
            {
                if (collision.gameObject.tag == "Shield1" || ((collision.gameObject.tag == "Shield2") && (hitCounter != 0)))
                {
                    reflectCollision(collision);
                }
            }

            if (hitCounter > collisionHits)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void reflectCollision(Collider2D collision)
    {
        CalculateNormal calculateNormal = collision.gameObject.GetComponent<CalculateNormal>();
        bulletMovement.movementDelta = (2 * Vector2.Dot(bulletMovement.movementDelta, calculateNormal.normal) * calculateNormal.normal) - bulletMovement.movementDelta;

        hitCounter++;
        hasHitted = true;
    }
}
