using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradebook : MonoBehaviour
{
    public Text title;
    public Text estimation;
    PlayerSave pSave;

    void Start()
    {
        if(PlayerPrefs.HasKey("exam_title"))
        {
            title.text = PlayerPrefs.GetString("exam_title");
            estimation.text = PlayerPrefs.GetInt("exam_point").ToString();
        }
    }

}
