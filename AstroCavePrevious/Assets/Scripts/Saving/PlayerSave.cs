using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave
{
    public int Coins;

    public int EquippedShipId;

    public List<int> OwnedShips;

    public PlayerSave()
    {
        OwnedShips = new List<int>() { 0 };
    }
}
