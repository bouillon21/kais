using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public Animator anim;
     
    public void switchScene(int lvlToLoad)
    {
        anim.Play("FadeOn");
        SceneManager.LoadScene(lvlToLoad);
    }
}
