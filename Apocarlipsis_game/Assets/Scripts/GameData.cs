using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

	public const int healthMax = 15;

    public static GameObject player1;
    public static GameObject player2;

    public static int gameRound = 1;
    public static int player1Lives = 4;
    public static int player2Lives = 4;
    public static int playerLives = 4;

	public static int player1Health = healthMax;
	public static int player2Health = healthMax;

	public static float time;

    public static bool roundOver;
    public static bool player1Won;
    public static bool player2Won;

    public static bool gameRunning;
    public static float gameStartTimer;

    public static float player1ShieldTime;
    public static float player2ShieldTime;

    public static void resetData()
    {
        GameData.player1Lives = GameData.playerLives;
        GameData.player2Lives = GameData.playerLives;
        resetHealth();
        GameData.gameRound = 1;
    }

    public static void resetHealth()
    {
		GameData.player2Health = healthMax;
		GameData.player1Health = healthMax;
    }

}
