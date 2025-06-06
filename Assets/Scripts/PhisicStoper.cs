using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhisicStoper : MonoBehaviour
{
    int i = 0;
    
    Rigidbody2D BallRigid;

    private void Start()
    {
        BallRigid = gameObject.GetComponent<Rigidbody2D>();
        BallRigid.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    private void OnEnable()
    {
        GameManager.GameManagerWinCommand += PhisicStop;
    }
    private void OnDisable()
    {
        GameManager.GameManagerWinCommand -= PhisicStop;
    }
    public void Click()
    {
        Debug.Log("тык");
        PhisicStop();
    }
    private void PhisicStop()
    {
        if (gameObject != null)
        {
            if (i == 0)
            {
                Debug.Log("Разморозка");
                BallRigid.constraints = RigidbodyConstraints2D.None;
                i = 1;
                Debug.Log("Тыканье");
                gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
                gameObject.GetComponent<CircleCollider2D>().isTrigger = false;

            }
            else
            {
                Debug.Log("Заморозка");
                BallRigid.constraints = RigidbodyConstraints2D.FreezeAll;
                i = 0;
            }
        }
        else
        {
            Debug.Log("null");
        }
    }
}
