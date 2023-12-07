using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanelUI : MonoBehaviour
{
    public GameObject ShopItemPrefab;

    public Transform ShopContainer;

    public void Setup(PlayerShipListConfig shipListConfig)
    {
        // Optionally use for i loop
        /*for(int i = 0; i < shipListConfig.Ships.Count; i++)
        {

        }*/

        foreach(PlayerShipConfig ship in shipListConfig.Ships)
        {
            GameObject newObject = Instantiate(ShopItemPrefab, ShopContainer);

            ShipShopItemUI shopItemUI = newObject.GetComponent<ShipShopItemUI>();
            shopItemUI.Setup(ship);
        }
    }
}
