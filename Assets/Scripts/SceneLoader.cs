using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public static void LoadMainMenuScreen()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public static void LoadLevel_1()
    {
        SceneManager.LoadScene("Level1");
    }

    public static void LoadGameOverScreen()
    {
        SceneManager.LoadScene("Game Over");
    }

    public static void LoadWinScreen()
    {
        SceneManager.LoadScene("Win");
    }
}
