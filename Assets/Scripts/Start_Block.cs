using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Start_Block : MonoBehaviour
{
    [SerializeField] GameObject basket;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        gameObject.SetActive(false);

        basket.SetActive(true);

        GameManager.instance.CountDown();
    }
}
