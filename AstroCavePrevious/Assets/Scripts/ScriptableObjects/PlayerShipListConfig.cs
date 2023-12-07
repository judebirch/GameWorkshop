using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Astro Cave/PlayerShipList")]
public class PlayerShipListConfig : ScriptableObject
{
    public List<PlayerShipConfig> Ships;
}
