using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenFish : MonoBehaviour
{
    private Vector3 mousePos;
    private SpriteRenderer spriteRenderer;
    private GameManager gameManager; 
    private GameUI gameUI;

    private void Start()
    {   
        gameUI = GameObject.Find("Game UI").GetComponent<GameUI>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        updateFish();
    }

    public void Move()
    {
        transform.position = Vector3.Lerp(transform.position, mousePos, Time.deltaTime);
        transform.right = mousePos - transform.position;

        if (Input.touchCount > 0 && Time.timeScale == 1)
        {
           
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
        }

        if (mousePos.x < transform.position.x)
        {
            spriteRenderer.flipY = true;
        }

        else
        {
            spriteRenderer.flipY = false;
        }
    }

    private void updateFish()
    {
        if (gameUI.image1.fillAmount == 1)
        {
            gameManager.blueFish.SetActive(true);
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
