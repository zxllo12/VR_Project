using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Basket : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance) - (distance / 2);

        transform.position = new Vector3(startPosition.x + x, startPosition.y, startPosition.z);
    }
}
