using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleSound : MonoBehaviour {

    public AudioSource[] idleSounds;
    private float soundTimer = 0;
    public float baseTime = 3;
    public float randomTime = 4;

    private void Awake()
    {
        soundTimer += baseTime + Random.Range(0, randomTime);
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(idleSounds.Length > 0) {
            soundTimer -= Time.deltaTime;
            if(soundTimer < 0)
            {
                idleSounds[Random.Range(0, idleSounds.Length)].Play();
                soundTimer += baseTime + Random.Range(0, randomTime);
            }
        }
    }
}
