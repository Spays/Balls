using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayCycle : MonoBehaviour
{
    public GameObject WinSquare;
    Collider2D WinCollider;
    int SceneID;
    // Start is called before the first frame update
    void Start()
    {
        SceneID = SceneManager.GetActiveScene().buildIndex;
        WinCollider = WinSquare.GetComponent<Collider2D>();
    }
    private void OnBecameInvisible()
    {
        SceneManager.UnloadSceneAsync(SceneID);
        SceneManager.LoadSceneAsync(SceneID);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
