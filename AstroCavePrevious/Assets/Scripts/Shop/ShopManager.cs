using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public PlayerShipListConfig Ships;

    public ShopPanelUI PanelUI;

    private void Start()
    {
        PanelUI.Setup(Ships);
    }

    public void LoadLevel(string levelPath)
    {
        SceneManager.LoadSceneAsync(levelPath, LoadSceneMode.Single);
    }
}
