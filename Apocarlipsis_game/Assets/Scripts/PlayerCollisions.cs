using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

    public AudioSource[] hitSounds;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		int life;


        if (collision.gameObject.tag == "Bullets2" || collision.gameObject.tag == "Bullets1")
        {
            BulletCollision bulletCollision = collision.gameObject.GetComponent<BulletCollision>();
            if (bulletCollision.hitCounter == 0)
            {
                if (gameObject.tag == "Player1" && collision.gameObject.tag == "Bullets1") { return; }
                if (gameObject.tag == "Player2" && collision.gameObject.tag == "Bullets2") { return; }
            }

            if (gameObject.tag == "Player1") { GameData.player1Health--; }
            else { GameData.player2Health--; }

            if (gameObject.tag == "Player1") { life = GameData.player1Health; }
            else { life = GameData.player2Health; }

            hitSounds[Random.Range(0, hitSounds.Length)].Play();

            if (life == 0)
            {
                gameObject.SetActive(false);
                if (gameObject.tag == "Player1") { GameManager.instance.onPlayer1Death(); }
                if (gameObject.tag == "Player2") { GameManager.instance.onPlayer2Death(); }
            }
        }
    }
}
