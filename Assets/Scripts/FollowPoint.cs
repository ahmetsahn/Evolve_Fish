using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoint : MonoBehaviour
{
    Vector3 mousePos;
    
    void FixedUpdate()
    {
        Move();
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
    }
}
