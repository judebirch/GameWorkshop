using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Astro Cave/Player Data")]
public class PlayerData: ScriptableObject
{
    // Object fields
    public float MaxHealth;
    public float CurrentHealth;
    public Transform RespawnPoint;
}