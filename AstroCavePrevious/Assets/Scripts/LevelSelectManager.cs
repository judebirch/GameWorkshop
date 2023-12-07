using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    public TMP_Text CoinsText;

    // Start is called before the first frame update
    void Start()
    {
        CoinsText.SetText("Coins: " + PlayerSaveHandler.CurrentSave.Coins);
    }

    public void LoadLevel(string levelPath)
    {
        SceneManager.LoadSceneAsync(levelPath, LoadSceneMode.Single);
    }
}
