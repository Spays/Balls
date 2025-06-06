using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextLevelTest : MonoBehaviour
{
    public void LevelClick()
    {
        SceneManager.LoadScene("Level2");
    }
}
