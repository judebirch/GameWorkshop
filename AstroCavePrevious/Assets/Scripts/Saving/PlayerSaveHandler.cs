using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerSaveHandler
{

    private static PlayerSave _currentSave;
    public static PlayerSave CurrentSave
    {
        get
        {
            if(_currentSave == null)
            {
                _currentSave = LoadPlayerData();
            }

            return _currentSave;
        }
    }

    private static string GetSavePath()
    {
        return Path.Combine(Application.persistentDataPath, "playerSave.txt");
    }

    public static PlayerSave LoadPlayerData()
    {
        if(!File.Exists(GetSavePath()))
        {
            PlayerSave newPlayerSave = new PlayerSave();
            SavePlayerData(newPlayerSave);
            return newPlayerSave;
        }

        string jsonData = File.ReadAllText(GetSavePath());
        PlayerSave loadedSave = JsonUtility.FromJson<PlayerSave>(jsonData);

        return loadedSave;
    }

    public static void SavePlayerData(PlayerSave data)
    {
        string jsonData = JsonUtility.ToJson(data);

        File.WriteAllText(GetSavePath(), jsonData);
    }
}
