using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static UIManager instance;

    public MainUI mainUI;
                      
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
        mainUI = FindObjectOfType<MainUI>();
        InitUI();
    }

    public void InitUI()
    {
        GameManager.Instance.SetData();
        mainUI.UpdateUI();
    }

    public void BackToMainUI()
    {
        mainUI.OnClickMainUI();
    }
}
