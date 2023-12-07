using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//shop manager, adds shape UI elements with the vertical layout group
public class ShopUI : MonoBehaviour
{
    public GameObject shopItemPrefab;//with the structure we set up

    public Transform verticalLayoutGroupParent;

    public void AddShopItem(ShapeItem item)
    {
        GameObject newGameObject = Instantiate(shopItemPrefab, verticalLayoutGroupParent);

        //just so it actually fits the description of each UI element
        newGameObject.GetComponent<ShopShapeUI>().Setup(item);
    }
}
