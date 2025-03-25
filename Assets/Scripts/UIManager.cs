using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static UIManager instance;

    public TextMeshProUGUI characterNameText;
    public TextMeshProUGUI levelValue;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI atkValue;
    public TextMeshProUGUI defValue;
    public TextMeshProUGUI hpValue;
    public TextMeshProUGUI crtValue;

    public GameObject mainUI;
    public GameObject statusUI;
    public GameObject inventoryUI;

    
   

    
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
        GameManager.Instance.SetData();
        //OnClickMainUI();
        UpdateUI();
    }

    public void UpdateUI()
    {
        var player = GameManager.Instance.Player;


        if (characterNameText != null)
        {
            characterNameText.text = player.Name;
            
        }

        if (levelValue != null)
        { 
            levelValue.text = player.Level.ToString();
        }

        if (goldText != null)
        {
            goldText.text = player.Gold.ToString();  
        }

        if (atkValue != null)
        {
            atkValue.text = player.Atk.ToString();
        }

        if (defValue != null)
        {
            defValue.text = player.Def.ToString();
        }

        if (hpValue != null)
        {
            hpValue.text = player.Hp.ToString();
        }

        if (crtValue != null)
        {
            crtValue.text = player.Crt.ToString();
        }
    }

    public void OnClickMainUI()
    {
        mainUI.SetActive(true);
        statusUI.SetActive(false);
        inventoryUI.SetActive(false);
    }

    public void OnClickStatusUI()
    {
        mainUI.SetActive(false);
        statusUI.SetActive(true);
        inventoryUI.SetActive(false);
    }

    public void OnClickInventoryUI()
    {
        mainUI.SetActive(false);
        statusUI.SetActive(false);
        inventoryUI.SetActive(true);
    }
        
}
