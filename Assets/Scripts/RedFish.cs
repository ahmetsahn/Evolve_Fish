using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedFish : FishBase
{
    
    private SpriteRenderer spriteRenderer;
    private GameManager gameManager;
    private GameUI gameUI;
    public PolygonCollider2D redFishCollider;
    public SpriteRenderer redFishSpriteRenderer;

    private void Start()
    {   
        gameUI = GameObject.Find("Game UI").GetComponent<GameUI>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        redFishSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        redFishCollider = gameObject.GetComponent<PolygonCollider2D>();
    }

    private void FixedUpdate()
    {
        Move(spriteRenderer);
    }

    private void Update()
    {
        Win();
    }

    


    private void Win()
    {
        if (gameUI.image2.fillAmount == 1)
        {
            redFishCollider.enabled = true;
            redFishSpriteRenderer.enabled = true;    
        }

        if (gameUI.image3.fillAmount == 1)
        {
            Destroy(gameObject);
            gameManager.winSound.Play();
            gameManager.gameMusic.Stop();
            gameManager.win = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bait"))
        {
            gameManager.score++;
            gameManager.baitSound.Play();
            gameUI.image3.fillAmount += 1/100f;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Blue Fish"))
        {
            gameManager.baitSound.Play();
            gameManager.score += 2;
            gameUI.image3.fillAmount += 2 / 100f;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Red Fish"))
        {
            gameManager.baitSound.Play();
            gameManager.score += 4;
            gameUI.image3.fillAmount += 4 / 100f;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Brown Fish"))
        {
            gameManager.deathSound.Play();
            gameManager.gameMusic.Stop();
            Instantiate(gameManager.fishbonePrefab, transform.position, gameManager.fishbonePrefab.transform.rotation);
            Destroy(gameObject);
            gameManager.death = true;
        }
    }
}
