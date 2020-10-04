using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private void Start()
    {
        PlayerInfo.levelTitle = SceneManager.GetActiveScene().name;
    }

    public static void LoadRandomLevel()
    {
        SceneManager.LoadSceneAsync(UnityEngine.Random.Range(1, SceneManager.sceneCountInBuildSettings - 1));
    }

    public static void QuitApp()
    {
        Application.Quit(0);
    }

    public static void LoadCredits()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }
}
