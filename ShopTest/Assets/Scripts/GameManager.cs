using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ShopUI shopUI;

    public List<ShapeItem> items;


    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in items)
        {
            shopUI.AddShopItem(item);
        }
    }
}
