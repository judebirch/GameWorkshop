using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PlayerInteractable
{
    protected override void OnPlayerTouch(Collider2D collision)
    {
        collision.gameObject.SendMessage("OnPlayerHitCoin");
        Destroy(gameObject);
    }
}
