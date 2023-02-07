using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Renderer : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    public SpriteRenderer SpriteRenderer => spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
