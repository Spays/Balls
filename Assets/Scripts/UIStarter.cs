using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStarter : MonoBehaviour
{
    public GameObject SecondPanel;
    private void Start()
    {
        SecondPanel.SetActive(false);
    }
    // Start is called before the first frame update
    private void OnEnable()
    {
        Debug.Log("�������� UI");
        GameManager.GameManagerWinCommand += UiStart;
    }
    private void OnDestroy()
    {
        Debug.Log("��������� UI");
        GameManager.GameManagerWinCommand -= UiStart;
    }
    private void UiStart()
    {
        Debug.Log("�� �� �������");
        SecondPanel.SetActive(true);
    }
    
}
