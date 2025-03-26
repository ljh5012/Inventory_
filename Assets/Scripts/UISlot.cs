using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public InventoryUI inventory;

    public ItemData itemdata;

    public int index;
    public Image onEquipImage;
    [SerializeField] private bool equipped;

    public GameObject iteminfo;

    public Button closeBtn;
    public Button equipBtn;
    public Button unequipBtn;


    public void Start()
    {
        // 버튼에 이벤트 리스너 연결
        if (equipBtn != null)
            equipBtn.onClick.AddListener(OnClickEquip);
        if (unequipBtn != null)
            unequipBtn.onClick.AddListener(OnClickUnEquip);
        if (closeBtn != null)
            closeBtn.onClick.AddListener(CloseInfo);

        if (iteminfo != null)
            iteminfo.SetActive(false);
    }

    public void SetItem()
    {
        //onEquip.gameObject.SetActive(true);
        //onEquip.sprite = itemdata.
    }

    public void RefreshUI()
    {
        
    }

    public void OnClickItem()
    {

        iteminfo.SetActive(true);

       
    }

    public void OnClickEquip()
    {
        Debug.Log($"슬롯 {index}의 Equip 버튼 눌림!");
        if (onEquipImage != null)
        {
            onEquipImage.gameObject.SetActive(true); // 장착 이미지를 보여줌
            Debug.Log($"슬롯 {index} onEquip 이미지 활성화");
        }
        else
        {
            Debug.LogWarning("onEquip 이미지가 null입니다!");
        }

        equipped = true; // 장착 상태로 설정

    }

    public void OnClickUnEquip()
    {

        if (onEquipImage != null)
        {
            onEquipImage.gameObject.SetActive(false);
        }

        equipped = false;
    }

    public void CloseInfo()
    {
        iteminfo.SetActive(false);
    }
}
