using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent_Destroy : MonoBehaviour
{
    void OnDestroy()
    {
        if (transform.parent != null)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
