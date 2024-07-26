using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Enemymovements : MonoBehaviour
{
    Animator animator;
    SpriteRenderer sr;
    //public float minX = -5f; 
    //public float maxX = 5f;  
    public float speed = 2.0f;
    public GameObject leftLimit;
    public GameObject rightLimit;

    private bool movingRight = true;

    public void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        float minX = leftLimit.transform.position.x;
        float maxX = rightLimit.transform.position.x;
        float x = Mathf.PingPong(Time.time * speed, maxX - minX) + minX;
        //Debug.Log(x);
        transform.position = new Vector2(x, transform.position.y);
        if (movingRight && x >= (maxX - 0.1f))
        {
            Flip();
            movingRight = false;
        }

        else if (!movingRight && x <= (minX + 0.1f))
        {
            Flip();
            movingRight = true;
        }
        //animator.SetFloat("velocity", Mathf.Abs(speed));
    }

    void Flip()
    {
        sr.flipX = !sr.flipX;
    }

}
