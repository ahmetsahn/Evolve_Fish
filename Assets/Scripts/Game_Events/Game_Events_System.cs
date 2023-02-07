using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Game_Events_System : MonoBehaviour
{
    public static Game_Events_System instance;
    

    public event UnityAction<Vector3> OnInput;
    public event UnityAction<float> OnToFillImageBar;
    public event UnityAction<int> OnIcrementScore;
    public event UnityAction OnPrintScore;
    public event UnityAction OnEatSound;
    public event UnityAction OnDie;
    public event UnityAction OnGameOverPanel;
    public event UnityAction OnWinPanel;
    


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void LoadInput(Vector3 mousePos)
    {      
        OnInput?.Invoke(mousePos);   
    }

    public void LoadIncrementScore(int scoreValue)
    {
        OnIcrementScore?.Invoke(scoreValue);
    }

    public void LoadPrintScore()
    {
        OnPrintScore?.Invoke();
    }

    public void LoadToFillImageBar(float value)
    {
        OnToFillImageBar?.Invoke(value);
    }

    public void LoadEatSound()
    {
        OnEatSound?.Invoke();
    }
    
    public void LoadDie()
    {
        OnDie?.Invoke();
    }

    public void LoadGameOverPanel()
    {
        OnGameOverPanel?.Invoke();
    }

    public void LoadWinPanel()
    {
        OnWinPanel?.Invoke();
    }

}
