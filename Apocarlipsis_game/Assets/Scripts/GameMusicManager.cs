using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicManager : MonoBehaviour {

    public AudioSource battle_intro;
    public AudioSource battle_loop;
    public AudioSource battle_fast_intro;
    public AudioSource battle_fast_loop;

    private void Awake()
    {
        battle_intro.Play();
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if ((GameData.player1Health <= 3 || GameData.player2Health <= 3) && !battle_fast_intro.isPlaying)
        {
            if((battle_loop.isPlaying || battle_intro.isPlaying) && !battle_fast_loop.isPlaying) {
                battle_loop.Stop();
                battle_intro.Stop();
                battle_fast_intro.Play();
            } else if (!battle_fast_loop.isPlaying) {
                battle_fast_loop.Play();
            }
        } else if(!battle_intro.isPlaying && !battle_loop.isPlaying && !battle_fast_intro.isPlaying && !battle_fast_loop.isPlaying)
        {
            battle_loop.Play();
        }
	}
}
