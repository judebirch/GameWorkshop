using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shape", menuName = "ScriptableObjects/Shape", order = 1)]
public class ShapeItem : ScriptableObject
{
    public int Id;

    public string Name;

    public Color Colour;

    public Sprite Image;

    public int Price;
}
