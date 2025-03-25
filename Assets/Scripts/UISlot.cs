using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UISlot : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI atkValue;
    [SerializeField] public TextMeshProUGUI defValue;
    [SerializeField] public TextMeshProUGUI hpValue;
    [SerializeField] public TextMeshProUGUI crtValue;

     

    public void SetItem()
    {

    }

    public void RefreshUI()
    {
        var player = GameManager.Instance.Player;

        atkValue.text = $"{player.Atk}";
        defValue.text = $"{player.Def}";
        hpValue.text = $"{player.Hp}";
        crtValue.text = $"{player.Crt}";
    }
}
