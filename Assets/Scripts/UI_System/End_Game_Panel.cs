using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Game_Panel : MonoBehaviour
{
    [SerializeField] 
    private GameObject gameOverPanel;
    [SerializeField] 
    private GameObject winPanel;
    private void Start()
    {
        Game_Events_System.instance.OnGameOverPanel += ActiveGameOverPanel;
        Game_Events_System.instance.OnWinPanel += ActiveWinPanel;
    }

    private void OnDisable()
    {
        Game_Events_System.instance.OnGameOverPanel -= ActiveGameOverPanel;
        Game_Events_System.instance.OnWinPanel -= ActiveWinPanel;
    }
   

    private void ActiveGameOverPanel()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    private void ActiveWinPanel()
    {
        Time.timeScale = 0;
        winPanel.SetActive(true);
    }
}
