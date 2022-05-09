using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buble : MonoBehaviour
{
    Rigidbody2D rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MoveUp();
    }

    private void MoveUp()
    {
        rb.AddForce(Vector2.up * 30 * Time.deltaTime);
    }
}
