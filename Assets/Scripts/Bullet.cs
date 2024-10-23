using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int scoreValue = 10;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);

            if (GameManager.instance != null)
            {
                GameManager.instance.AddScore(scoreValue);
            }
        }      
    }
}
