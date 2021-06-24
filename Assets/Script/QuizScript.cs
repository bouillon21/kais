using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public QuestionList[] question;
    QuestionList crntQuestion;
    public Text QuestionText;
    public Text[] AnswerText;
    List<QuestionList> qList;
    public PlayerSave pSave;

    int rnd;
    int correct;
    void Start()
    {
        qList = new List<QuestionList>(question);
        RandomQuestion();
    }

    void RandomQuestion()   
    {
        if (qList.Count != 0)
        {
            rnd = Random.Range(0, qList.Count);
            crntQuestion = qList[rnd];

            QuestionText.text = crntQuestion.question;
            List<string> Answer = new List<string>(crntQuestion.answer);
            for (int i = 0; i < 4; i++)
            {
                int rnd2 = Random.Range(0, Answer.Count);
                AnswerText[i].text = Answer[rnd2];
                Answer.RemoveAt(rnd2);
            }
        }
        else
        {
            PlayerPrefs.SetString("exam_title", "экзамен1");
            PlayerPrefs.SetInt("exam_point", correct);

            //pSave.exams.Add(new exam("экзамен1", correct));
            print("end, correct answer = " + correct);
            SceneManager.LoadScene(2);
        }
    }

    public void PressAnswerBtn(int index)
    {
        if (AnswerText[index].text == crntQuestion.answer[0])
            correct++;
        else
            print("no cool");
        qList.RemoveAt(rnd);
        RandomQuestion();
    }

}

[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answer = new string [4];
}
