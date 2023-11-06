using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : PlayerCollidableBehaviour
{
    protected override void OnPlayerCollide(Collider2D collision)
    {
        collision.gameObject.SendMessage("CollidedWithCheckpoint", this);
    }
}
