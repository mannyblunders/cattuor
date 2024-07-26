using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Catmoves : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 5f;
    SpriteRenderer sr;
    Rigidbody2D rb;
    public Animator animator;
    public bool OnGround;
    public Transform chek;
    public float radius = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {


        float movement1 = Input.GetAxis("Horizontal");
        float movement2 = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement1, movement2, 0) * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && MathF.Abs(rb.velocity.y) < 0.05f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        sr.flipX = movement1 < 0 ? true : false;
        animator.SetFloat("HorizontalMove", MathF.Abs(movement1));


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("camera"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.CompareTag("Collect"))
        {
            itemkey itemkey = collision.gameObject.GetComponent<itemkey>();
            if (itemkey != null)
            {
                itemkey.collect();
            }
        }
    }
}