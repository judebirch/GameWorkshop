#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Assets.Scripts.Editor
{
    class QuickBuildEditor
    {
        [MenuItem("PAL Games/Logger/Log something")]
        public static void LogSomethingToTheConsole()
        {
            Debug.Log("something");
            EditorApplication.Beep();
        }

        [MenuItem("PAL Games/Quick Debug Build")]
        public static void BuildGame()
        {
            // Get filename.
            string path = "Builds/QuickBuilds";
            EditorBuildSettingsScene[] scenes = EditorBuildSettings.scenes;
            // Build player.
            BuildPipeline.BuildPlayer(scenes, path + "/BuiltGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

            // Copy a file from the project folder to the build folder, alongside the built game.
            //FileUtil.CopyFileOrDirectory("Assets/Templates/Readme.txt", path + "Readme.txt");

            // Run the game (Process class from System.Diagnostics).
            Process proc = new Process();
            proc.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\" + path + "\\" + "BuiltGame.exe";
            proc.Start();
        }
    }
}

#endif