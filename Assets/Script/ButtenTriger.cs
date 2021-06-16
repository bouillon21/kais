using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtenTriger : MonoBehaviour
{
    public Animator anim; 
    public GameObject SwitchScene;
    public int Scene;


    public void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Player"))
        {
            SwitchScene.GetComponent<SwitchScene>().SceneToLoad = Scene;
            anim.Play("OnButten");
        }
    }
    public void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
            anim.Play("OffButten");
    }
}
