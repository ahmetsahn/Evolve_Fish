using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score_System : MonoBehaviour
{
    public static Score_System instance;

    [SerializeField]
    private int score;
    public int Score => score;

    [SerializeField]
    private Text scoreText;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        Game_Events_System.instance.OnIcrementScore += UpdateScore;
        Game_Events_System.instance.OnPrintScore += PrintScore;
    }
    private void UpdateScore(int scoreValue)
    {
        score += scoreValue;
    }

    private void PrintScore()
    {
        scoreText.text = "Score: "+score.ToString();
    }

    
}
