using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    //public int lvSelect;


    private void Start()
    {
        PlayerInfo.levelTitle = SceneManager.GetActiveScene().name;

    }



    public /* static*/ void LoadRandomLevel()
    {
        //int lvSelect = UnityEngine.Random.Range((int)1, (int)(7 + 1));//last num is exclusive
        int lvSelect = 7;
        //UnityEngine.Debug.Log(lvSelect);

        //set name based on level #
        //level titles live here so we dont have to worry about choosing scene based on name
        switch (lvSelect) {
            case 1:
                PlayerInfo.levelTitle = "Level 1";
                break;
            case 2:
                PlayerInfo.levelTitle = "Level 2";
                break;
            case 3:
                PlayerInfo.levelTitle = "Level 3";
                break;
            case 4:
                PlayerInfo.levelTitle = "Level 4";
                break;
            case 5:
                PlayerInfo.levelTitle = "Level 5";
                break;
            case 6:
                PlayerInfo.levelTitle = "Level 6";
                break;
            case 7:
                PlayerInfo.levelTitle = "Lake Ludum";
                break;
            default:
                PlayerInfo.levelTitle = $"{lvSelect}";
                break;
        }

       // UnityEngine.Debug.Log(PlayerInfo.levelTitle);

        SceneManager.LoadSceneAsync($"Level {lvSelect}");
        Application.LoadLevel(lvSelect + 1);
    }

    public /* static*/ void QuitApp()
    {
        Application.Quit(0);
    }

    public /* static*/ void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
        Application.LoadLevel(9);
    }
}
