using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//UI for each shop element
public class ShopShapeUI : MonoBehaviour
{
    public TMP_Text text;

    public Image image;

    public Button buyButton;

    public void Setup(ShapeItem item)
    {
        text.SetText(item.Name + "\n" + item.Price + "g");

        image.sprite = item.Image;
        image.color = item.Colour;
    }
}
