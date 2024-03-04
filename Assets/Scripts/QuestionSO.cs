using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{

    [TextArea(1, 6)]
    [SerializeField] private string question = "Enter your question here";
    [SerializeField] private string[] answers = new string[4];
    [SerializeField] private int correctAnswerIdx;


    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIdx()
    {
        return correctAnswerIdx;
    }

    public string GetAnswer(int correctAnswerIdx)
    {
        return answers[correctAnswerIdx];
    }

}
