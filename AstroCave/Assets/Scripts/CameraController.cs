using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform followingTransform;

    private Vector3 offset = Vector3.forward * -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(followingTransform != null)
        {
            transform.position = followingTransform.position + offset;
        }
    }
}
