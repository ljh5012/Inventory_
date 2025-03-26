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
        // ��ư�� �̺�Ʈ ������ ����
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
        Debug.Log($"���� {index}�� Equip ��ư ����!");
        if (onEquipImage != null)
        {
            onEquipImage.gameObject.SetActive(true); // ���� �̹����� ������
            Debug.Log($"���� {index} onEquip �̹��� Ȱ��ȭ");
        }
        else
        {
            Debug.LogWarning("onEquip �̹����� null�Դϴ�!");
        }

        equipped = true; // ���� ���·� ����

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
