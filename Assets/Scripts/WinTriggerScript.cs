using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class WinTriggerScript : MonoBehaviour
{
    public static Action onWin;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("WIN");
        onWin();
    }
    
}
