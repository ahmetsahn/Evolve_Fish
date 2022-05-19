using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlueFish : MonoBehaviour
{
    private Vector3 mousePos;
    private SpriteRenderer spriteRenderer;
    private GameManager gameManager;
    private GameUI gameUI;
    private PolygonCollider2D blueFishCollider;
    private SpriteRenderer blueFishSpriteRenderer;
    

    private void Start()
    {
        gameUI = GameObject.Find("Game UI").GetComponent<GameUI>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        blueFishSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        blueFishCollider = gameObject.GetComponent<PolygonCollider2D>();
    }

    private void FixedUpdate()
    {
        Move();
        
    }

    private void Update()
    {
        updateFish();
    }

    private void Move()
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

            blueFishCollider.enabled = true;
            blueFishSpriteRenderer.enabled = true;
            
        }

        if(gameUI.image2.fillAmount==1)
        {
            gameObject.SetActive(false);
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bait"))
        {
            gameManager.score++;
            gameManager.baitSound.Play();
            gameUI.image2.fillAmount += 1/25f;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Blue Fish"))
        {
            gameManager.score += 2;
            gameUI.image2.fillAmount += 2 / 25f;
            gameManager.baitSound.Play();
            Destroy(collision.gameObject);   
        }

        if (collision.CompareTag("Red Fish") || collision.CompareTag("Brown Fish"))
        {
            gameManager.deathSound.Play();
            gameManager.gameMusic.Stop();
            Instantiate(gameManager.fishbonePrefab, transform.position, gameManager.fishbonePrefab.transform.rotation);
            Destroy(gameObject);
            gameManager.death = true;
        }
    }
}
