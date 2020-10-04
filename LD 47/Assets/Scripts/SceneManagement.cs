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
        SceneManager.LoadSceneAsync(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
    }

    public static void QuitApp()
    {
        Application.Quit();
    }

    public static void LoadCredits()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
    }
}
