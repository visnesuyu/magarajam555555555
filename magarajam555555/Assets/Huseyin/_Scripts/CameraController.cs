using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;

    private Vector2 offset;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
