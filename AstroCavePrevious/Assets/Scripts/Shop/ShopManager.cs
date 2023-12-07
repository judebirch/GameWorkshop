using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public PlayerShipListConfig Ships;

    public ShopPanelUI PanelUI;

    private void Start()
    {
        PanelUI.Setup(Ships);
    }
}
