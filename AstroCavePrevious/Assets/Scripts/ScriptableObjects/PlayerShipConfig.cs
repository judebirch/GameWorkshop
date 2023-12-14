using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Astro Cave/PlayerShip")]
public class PlayerShipConfig : ScriptableObject
{
    public int Id;

    public float BoostPower;

    public float RotationSpeed;

    public float Mass;

    public Sprite Ship;

    public int Cost;

    public string Name;
}
