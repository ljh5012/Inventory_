using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : UIManager
{
    public Button backBtn;

    public TextMeshProUGUI atkValue;
    public TextMeshProUGUI defValue;
    public TextMeshProUGUI hpValue;
    public TextMeshProUGUI crtValue;

    public void Start()
    {
        backBtn.onClick.AddListener(BackToMainUI);
        UpdateStatUI();
    }

    

    public void UpdateStatUI()
    {
        var player = GameManager.Instance.Player;

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

}
