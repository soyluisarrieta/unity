using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject John;

    void Update()
    {
        if (John == null) return;

        Vector3 position = transform.position;
        position.x = John.transform.position.x;
        transform.position = position;
    }
}
