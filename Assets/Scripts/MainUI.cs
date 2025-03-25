using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public static MainUI Instance;

    public Button statusBtn;
    public Button inventoryBtn;

    public TextMeshProUGUI characterNameText;
    public TextMeshProUGUI levelValue;
    public TextMeshProUGUI goldText;

    public GameObject mainUI;
    public GameObject statusUI;
    public GameObject inventoryUI;

    public void Awake()
    {
        Instance = this;
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
