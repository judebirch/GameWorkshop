using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public PlayerData data;
    public PlayerMovementData movementData;
    public PlayerMovementData movementDataAlternative;
    public PlayerMovementData activeMovementData;

    public string LevelScenePath;

    private float timeSinceLastSwitched = 0f;
    private float _currentRotation = 0f;
    private float _currentBoost = 0f;

    private Rigidbody2D _body;

    public int Coins;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        activeMovementData = movementData;
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _body.AddTorque(-activeMovementData.torqueSpeed * _currentRotation * Time.fixedDeltaTime);

        _body.AddRelativeForce(Vector2.up * _currentBoost * activeMovementData.boostPower);
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
        _body.position = data.RespawnPoint.position;
    }

    public void OnPlayerHitCheckpoint(CheckPoint checkPoint)
    {
        // Set the position of the respawn point, to the position of the checkpoint
        data.RespawnPoint = checkPoint.transform;
    }

    public void OnPlayerHitCoin()
    {
        Coins++;
        scoreText.SetText("Coins: " + Coins.ToString());
    }

    public void OnPlayerCompleteLevel()
    {
        PlayerSaveHandler.CurrentSave.Coins += Coins;
        PlayerSaveHandler.SavePlayerData(PlayerSaveHandler.CurrentSave);

        SceneManager.LoadSceneAsync(LevelScenePath, LoadSceneMode.Single);
    }
}
