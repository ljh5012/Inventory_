using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static UIManager instance;

                      
    public static UIManager Instance
    {
        get 
        { 
            return instance; 
        }
    }

    private void Awake()
    {
        instance = this;
    }

    

    public void Start()
    {
        InitUI();
    }

    public void InitUI()
    {
        GameManager.Instance.SetData();
        MainUI.Instance.UpdateUI();
    }

    public void BackToMainUI()
    {
        MainUI.Instance.OnClickMainUI();
    }
}
