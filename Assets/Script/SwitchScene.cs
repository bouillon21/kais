using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public Animator anim;
    public int SceneToLoad;

    public void switchScene()
    {
        anim.Play("FadeOn");
        SceneManager.LoadScene(SceneToLoad);
    }
}
