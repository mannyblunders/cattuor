using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float MaxX, MinX, MinY, MaxY;
    [SerializeField] Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
                   Mathf.Clamp(target.position.x, MinX, MaxX),
                   Mathf.Clamp(target.position.y, MinY, MaxY),
                   -10
               );
    }
}
