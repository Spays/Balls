using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    int SceneID;
    private void Start()
    {
        SceneID = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnEnable()
    {
        WinTriggerScript.onWin += OnPlayerWin;
    }
    private void OnDisable()
    {
        WinTriggerScript.onWin -= OnPlayerWin;
    }
    public static Action GameManagerWinCommand;
    private void OnPlayerWin()
    {

        Debug.Log("Я вижу он выиграл");
        GameManagerWinCommand();


    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneID);
    }
}
