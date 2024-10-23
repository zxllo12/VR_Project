using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Block : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Application.Quit();
    }
}
