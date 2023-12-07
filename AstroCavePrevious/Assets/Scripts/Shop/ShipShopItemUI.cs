using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipShopItemUI : MonoBehaviour
{
    public TMP_Text NameUI;

    public void Setup(PlayerShipConfig shipConfig)
    {
        NameUI.SetText(shipConfig.Name);
    }
}
