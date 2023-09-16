using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void HomeScene()
    {
        SceneManager.LoadScene(0);
    }

    public void GuideScene()
    {
        SceneManager.LoadScene(3);
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene(5);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
