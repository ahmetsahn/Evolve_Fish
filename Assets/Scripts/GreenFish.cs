using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenFish : FishBase
{
    
    private SpriteRenderer greenFishSpriteRenderer;
    private GameManager gameManager; 
    private GameUI gameUI;

    private void Start()
    {   
        gameUI = GameObject.Find("Game UI").GetComponent<GameUI>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        greenFishSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move(greenFishSpriteRenderer);
    }

    private void Update()
    {
        updateFish();
    }

    

    private void updateFish()
    {
        if (gameUI.image1.fillAmount == 1)
        {        
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bait"))
        {
            gameManager.score++;
            gameManager.baitSound.Play();
            gameUI.image1.fillAmount += 1/10f;
            Destroy(collision.gameObject);
        }
    
       if(collision.CompareTag("Blue Fish") || collision.CompareTag("Red Fish") || collision.CompareTag("Brown Fish"))
        {
            gameManager.gameMusic.Stop();
            gameManager.deathSound.Play();
            Instantiate(gameManager.fishbonePrefab, transform.position,gameManager.fishbonePrefab.transform.rotation);
            Destroy(gameObject);
            gameManager.death = true;
        }     
    }
}
