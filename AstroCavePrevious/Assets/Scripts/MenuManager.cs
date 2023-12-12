using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void LoadLevelSingle(string levelPath)
    {
        LoadLevel(levelPath, LoadSceneMode.Single);
    }

    public void LoadLevelAdditive(string levelPath)
    {
        LoadLevel(levelPath, LoadSceneMode.Additive);
    }

    private void LoadLevel(string levelPath, LoadSceneMode mode)
    {
        SceneManager.LoadSceneAsync(levelPath, mode);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
