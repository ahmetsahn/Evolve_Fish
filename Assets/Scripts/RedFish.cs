using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedFish : MonoBehaviour
{
    private Vector3 mousePos;
    private SpriteRenderer sr;
    private GameManager gameManager;
    private GameUI gameUI;
    
   
    private void Start()
    {   
        gameUI = GameObject.Find("Game UI").GetComponent<GameUI>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        sr =gameObject.GetComponent<SpriteRenderer>();
        FollowPointPosition();   
        sr.flipX = true;
    }

    private void FixedUpdate()
    {
        Move();
        FollowPointPosition();
    }

    private void Update()
    {
        Win();
        
    }

    private void Move()
    {
        transform.position = Vector3.Lerp(transform.position, mousePos, Time.deltaTime);
        transform.right = mousePos - transform.position;

        if (Input.touchCount > 0 && Time.timeScale == 1)
        {
            sr.flipX = false;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
        }

        if (mousePos.x < transform.position.x)
        {

            sr.flipY = true;
        }

        else
        {
            sr.flipY = false;
        }
    }

    private void Win()
    {
        if (gameUI.image3.fillAmount == 1)
        {
            Destroy(gameObject);
            gameManager.winSound.Play();
            gameManager.gameMusic.Stop();
            gameManager.win = true;
        }
    }

    private void FollowPointPosition()
    {
        transform.position = gameManager.followPoint.position;
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
