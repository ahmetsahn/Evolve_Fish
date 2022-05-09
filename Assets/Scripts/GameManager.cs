using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    
    public GameObject fishbonePrefab;    
    public GameObject blueFish;
    public GameObject redFish;
    public AudioSource gameMusic;   
    public AudioSource baitSound;    
    public AudioSource deathSound;    
    public AudioSource winSound;
    public Transform followPoint;
    private GameUI gameUI;
    public bool win;
    public bool death;
    public int score = 0;
    private int highScore;

    

    private void Start()
    {
        gameUI = GameObject.Find("Game UI").GetComponent<GameUI>();
        Time.timeScale = 1;
        score = 0;
        gameUI.highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore", highScore);
    }

    private void Update()
    {
        UpdateScore();
        WinControl();
        DeathControl();
    }

    private void UpdateScore()
    {
        gameUI.scoreText.text = "Score : " + score;
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }

    private void WinControl()
    {
        if (win)
        {
            gameUI.winUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void DeathControl()
    {
        if (death)
        {
            StartCoroutine(finished());
        }

        IEnumerator finished()
        {

            yield return new WaitForSeconds(2);
            gameUI.loseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }



}
