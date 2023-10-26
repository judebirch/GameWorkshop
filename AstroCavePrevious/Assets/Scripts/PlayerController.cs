using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float boostPower = 40f;
    public float torqueSpeed = 25f;

    public Transform respawnPoint;

    private float _currentRotation = 0f;
    private float _currentBoost = 0f;

    private Rigidbody2D _body;

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _body.AddTorque(-torqueSpeed * _currentRotation * Time.fixedDeltaTime);

        _body.AddRelativeForce(Vector2.up * _currentBoost * boostPower);
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        _currentRotation = context.ReadValue<float>();
    }

    public void OnBoost(InputAction.CallbackContext context)
    {
        _currentBoost = context.ReadValue<float>();
    }

    public void OnPlayerHitObstacle()
    {
        _body.position = respawnPoint.position;
    }
}
