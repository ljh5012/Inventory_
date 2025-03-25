using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public MyCharacterData Player;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    

    public void SetData()
    {
        Player = new MyCharacterData("Rtan", 1, 5, 5, 100, 50, 50000);

        //UIManager.Instance.UpdateUI();
    }
}
