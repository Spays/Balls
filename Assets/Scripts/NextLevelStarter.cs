using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelStarter : MonoBehaviour
{
    
    public void LevelClick()
    {
        Debug.Log("Яћъвћъ");
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("SampleScene");
    }
}
