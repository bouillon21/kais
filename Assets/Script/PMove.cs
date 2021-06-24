using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator anim;
    public SpriteRenderer sr;

    public float speed = 6;
    public float directionInput;
    public bool faceRigh = true;

    void Start()
    {
        //transform.position = pos.pos;
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
        rb.velocity = new Vector2(directionInput * speed, rb.velocity.y);
        anim.SetFloat("moveX", Mathf.Abs(directionInput));
    }

    public void Move(int InputAxis)
    {
        directionInput = InputAxis;
    }

    void Flip()
    {
        if ((directionInput > 0 && !faceRigh) || (directionInput < 0 && faceRigh))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRigh = !faceRigh;
        }
    }
}
