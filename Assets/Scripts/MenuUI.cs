using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    private void playButton()
    {
        SceneManager.LoadScene("Game");
    }

    private void quitButton()
    {
        Application.Quit();
    }
}
