using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShipShopItemUI : MonoBehaviour
{
    public TMP_Text NameUI;

    public Button Button;
    public TMP_Text ButtonText;

    private int shipId;
    private System.Action refreshPageAction;

    public void Setup(PlayerShipConfig shipConfig, System.Action refreshPage)
    {
        shipId = shipConfig.Id;
        refreshPageAction = refreshPage;

        NameUI.SetText(shipConfig.Name + System.Environment.NewLine + "Price: " + shipConfig.Cost);

        bool shipOwned = PlayerSaveHandler.CurrentSave.OwnedShips.Contains(shipConfig.Id);
        bool equipped = PlayerSaveHandler.CurrentSave.EquippedShipId == shipConfig.Id;
        bool canAfford = PlayerSaveHandler.CurrentSave.Coins >= shipConfig.Cost;

        if(shipOwned)
        {
            if(equipped)
            {
                // Ship is equipped already
                ButtonText.SetText("Equipped");
                Button.interactable = false;
            }
            else
            {
                // Ship is equippable
                ButtonText.SetText("Equip");
                Button.interactable = true;

                Button.onClick.AddListener(EquipShip);
            }
        }
        else
        {
            Button.interactable = canAfford;

            ButtonText.SetText("Buy");

            Button.onClick.AddListener(BuyShip);
        }
    }

    private void BuyShip()
    {
        // Buy ship clicked
        PlayerSaveHandler.CurrentSave.OwnedShips.Add(shipId);
        PlayerSaveHandler.SavePlayerData(PlayerSaveHandler.CurrentSave);

        refreshPageAction.Invoke();
    }


    private void EquipShip()
    {
        // Equip ship
        PlayerSaveHandler.CurrentSave.EquippedShipId = shipId;
        PlayerSaveHandler.SavePlayerData(PlayerSaveHandler.CurrentSave);

        refreshPageAction.Invoke();
    }
}
