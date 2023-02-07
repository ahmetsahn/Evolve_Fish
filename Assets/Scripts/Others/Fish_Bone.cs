using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Bone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(EndGameTimer());
        }
    }

    IEnumerator EndGameTimer()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Ground");
        Game_Events_System.instance.LoadGameOverPanel();
    }
    
}
