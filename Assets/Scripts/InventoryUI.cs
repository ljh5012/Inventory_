using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;
//using UnityEngine.UIElements;


public class InventoryUI : UIManager
{
    public Button backBtn;
    

    private UISlot selectedItem;
    private UISlot selectedItemindex;
    public TextMeshProUGUI itemNameText;
    public TextMeshProUGUI itemValueText;
    public TextMeshProUGUI itemDescriptionText;

    public UISlot[] slots;

    public Transform slotPanel;

    
    public ItemList itemarray;

    public Button[] buttons;



    public void Start()
    {

        backBtn.onClick.AddListener(BackToMainUI);

        slots = new UISlot[slotPanel.childCount];

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<UISlot>();
            slots[i].index = i;
            slots[i].inventory = this;
            
        }

        
        AssignItemsToButtons();

       
    }
    

    

    public void AssignItemsToButtons() // 버튼에 아이템 할당
    {
        for (int i = 0; i < buttons.Length && i < itemarray.items.Length; i++)
        {
            int index = i;
            Text buttonText = buttons[i].GetComponentInChildren<Text>();
            if (buttonText != null)
            {
                buttonText.text = itemarray.items[i].itemName;
            }

            buttons[i].onClick.AddListener(() => OnItemButtonClick(itemarray.items[index]));
        }
    }

    public void OnItemButtonClick(ItemData item)
    {
        

        // 선택 UI 텍스트 설정
        itemNameText.text = item.itemName;
        itemDescriptionText.text = item.itemDescription;
        itemValueText.text = item.itemValue.ToString();
    }

   

}
