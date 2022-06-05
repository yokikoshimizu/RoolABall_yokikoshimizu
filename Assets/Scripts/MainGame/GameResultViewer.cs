using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResultViewer : MonoBehaviour
{
    public PlayerPickupItemManager PlayerPickupItemManager;
    public TextMeshProUGUI ResultText;

    private void Start()
    {
        ResultText.text = string.Empty;
    }

    private void Update()
    {
        if(PlayerPickupItemManager.GetAllPickupItems){
            ResultText.text = "Game Clear";
        }
    }
}
