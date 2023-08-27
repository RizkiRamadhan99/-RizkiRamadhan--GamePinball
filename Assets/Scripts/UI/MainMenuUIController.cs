using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditsButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsButton.onClick.AddListener(CreditScene);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void HomeScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}