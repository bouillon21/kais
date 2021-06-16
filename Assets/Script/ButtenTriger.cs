using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtenTriger : MonoBehaviour
{
    public Animator anim;


    public void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Player"))
            anim.Play("OnButten");
    }
    public void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
            anim.Play("OffButten");
    }
}
