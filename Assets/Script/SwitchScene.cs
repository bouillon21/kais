using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public Animator anim;
    public int SceneToLoad;

    public void switchScene(int lvl)
    {
        if (lvl > 0)
            SceneToLoad = lvl;
        else if (lvl == -1 || SceneToLoad == -1)
            Exit();
        anim.Play("FadeOn");
        SceneManager.LoadScene(SceneToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
