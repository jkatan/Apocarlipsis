using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldFill : MonoBehaviour {

    public Image fillImage;
    public int player = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float fillAmount = 0;
        if(player == 1)
        {
            fillAmount = GameData.player1ShieldTime / 4;
        } else if(player == 2)
        {
            fillAmount = GameData.player2ShieldTime / 4;
        }

        Debug.Log(fillAmount);
        Debug.Log(GameData.player1ShieldTime);
        fillImage.fillAmount = fillAmount;
    }
}
