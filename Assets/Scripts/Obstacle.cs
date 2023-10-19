using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : PlayerCollidableBehaviour
{
    protected override void OnPlayerCollide(Collider2D collision)
    {
        collision.GetComponent<PlayerController>().Respawn();
    }
}
