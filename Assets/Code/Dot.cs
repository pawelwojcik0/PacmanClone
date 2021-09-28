using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            gameObject.SetActive(false);
            GamePlayManager.Instance.Points += 1;
        }
    } 
}
