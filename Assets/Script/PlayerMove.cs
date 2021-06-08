using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator anim;
    public SpriteRenderer sr;
    public float speed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Walk();
        Flip();
    }

    void Walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
    }

    void Flip()
    {
        sr.flipX = moveVector.x < 0;
    }
}
