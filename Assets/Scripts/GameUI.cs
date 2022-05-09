using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public GameObject winUI;
    public GameObject loseUI;
    public GameObject resumeUI;
    public Image image1;
    public Image image2;
    public Image image3;

    private void playButton()
    {
        SceneManager.LoadScene("Game");
    }

    private void quitButton()
    {
        Application.Quit();
    }

    private void pauseButton()
    {
        Time.timeScale = 0;

        resumeUI.SetActive(true);
    }
    private void resumeButton()
    {
        Time.timeScale = 1;
        resumeUI.SetActive(false);
    }

    private void menuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
