using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Renderer : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite blueFishSprite;
    public Sprite BlueFishSprite => blueFishSprite;

    [SerializeField]
    private Sprite redFishSprite;
    public Sprite RedFishSprite => redFishSprite;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        Game_Events_System.instance.OnInput += FlipSpriteRenderer;
    }

    public void FlipSpriteRenderer(Vector3 _mousePos)
    {
        if (_mousePos.x < transform.position.x)
        {
            spriteRenderer.flipY = true;
        }

        else
        {
            spriteRenderer.flipY = false;
        }
    }
}
