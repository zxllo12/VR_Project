using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform point;
    [SerializeField] float speed = 5f;

    [SerializeField] InputActionReference primary;
    [SerializeField] InputActionReference second;

    float maxSpeed = 15f;

    float minimumSpeed = 1f;

    private void OnEnable()
    {
        primary.action.Enable();
        second.action.Enable();
    }

    private void OnDisable()
    {
        primary.action.Disable();
        second.action.Disable();
    }

    private void Update()
    {
        if (second.action.WasPressedThisFrame()) // GetKeyDown
        {
            if (speed < maxSpeed)
            {
                speed += 1f;

                if (GameManager.instance != null)
                {
                    GameManager.instance.BulletSpeed(speed);
                }
            }
        }

        if (primary.action.WasPressedThisFrame()) // GetKeyDown
        {
            if (speed > minimumSpeed)
            {
                speed -= 1f;

                if (GameManager.instance != null)
                {
                    GameManager.instance.BulletSpeed(speed);
                }
            }
        }

        //if (primary.action.IsPressed()) //GetKey
        //{

        //}

        //if (primary.action.WasReleasedThisFrame()) // GetKeyUp
        //{

        //}
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, point.position, point.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.velocity = bullet.transform.forward * speed;
    }
}
