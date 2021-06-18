using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtenTriger : MonoBehaviour
{
    public GameObject Button;
    public GameObject SwitchScene;
    public string Title;
    public int Scene;

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("Player"))
        {
            Button.GetComponent<Animator>().Play("OnButten");
            Button.GetComponentInChildren<Text>().text = Title;
            SwitchScene.GetComponent<SwitchScene>().SceneToLoad = Scene;
        }
    }
    public void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
            Button.GetComponent<Animator>().Play("OffButten");
    }
}
    