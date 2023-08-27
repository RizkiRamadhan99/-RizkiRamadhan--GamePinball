using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsUIController : MonoBehaviour
{
    public Button homeButton;

    private void Start()
    {
        homeButton.onClick.AddListener(HomeScene);
    }
    public void HomeScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}