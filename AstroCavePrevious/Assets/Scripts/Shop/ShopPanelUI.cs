using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanelUI : MonoBehaviour
{
    public GameObject ShopItemPrefab;

    public Transform ShopContainer;

    private PlayerShipListConfig currentList;

    public TMP_Text CoinsText;

    public void Setup(PlayerShipListConfig shipListConfig)
    {
        CoinsText.text = "Coins: " + PlayerSaveHandler.CurrentSave.Coins;

        currentList = shipListConfig;

        foreach(PlayerShipConfig ship in shipListConfig.Ships)
        {
            GameObject newObject = Instantiate(ShopItemPrefab, ShopContainer);

            ShipShopItemUI shopItemUI = newObject.GetComponent<ShipShopItemUI>();
            shopItemUI.Setup(ship, Refresh);
        }
    }

    public void Refresh()
    {
        foreach(Transform child in ShopContainer)
        {
            Destroy(child.gameObject);
        }

        Setup(currentList);
    }
}
