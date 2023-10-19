using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class PlayerCollidableBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            OnPlayerCollide(collision);
        }
    }

    protected abstract void OnPlayerCollide(Collider2D collision);
}
