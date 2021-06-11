using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator anim;
    public SpriteRenderer sr;
    public float speed = 2;
    //public int directionInput;
    public bool faceRigh = true;

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
        if ((moveVector.x > 0 && !faceRigh) || (moveVector.x < 0 && faceRigh))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRigh = !faceRigh;
        }

        //sr.flipX = moveVector.x < 0;
    }
}
