using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public Transform CameraTransform;

    public float Mulitplier;

    private void LateUpdate()
    {
        transform.position = CameraTransform.position * Mulitplier + Vector3.forward *30;
    }
}
