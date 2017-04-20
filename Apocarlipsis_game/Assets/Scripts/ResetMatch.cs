using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetMatch : MonoBehaviour {

    public void ResetGame()
    {
        GameData.resetData();
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}
