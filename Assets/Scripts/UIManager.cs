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

    public GameObject mainUI;
    public GameObject statusUI;
    public GameObject inventoryUI;

    
   

    public CharacterData characterData;
    public static UIManager Instance
    {
        get 
        { 
            return instance; 
        }
    }

    public void Start()
    {
        characterData = new CharacterData("Rtan", 1, 1, 1, 1, 1, 50000);
        UpdateUI();
        OnClickMainUI();
    }

    public void UpdateUI()
    {
        if (characterNameText != null)
        {
            characterNameText.text = characterData.Name;
            Debug.Log(characterData.Name);
        }

        if (levelValue != null)
        { 
            levelValue.text = characterData.Level.ToString();
        }

        if (goldText != null)
        {
            goldText.text = characterData.Gold.ToString();  
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
