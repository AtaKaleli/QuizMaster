using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{


    [SerializeField] private QuestionSO questionSO;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private GameObject[] answerButtons;

    void Start()
    {
        questionText.text = questionSO.GetQuestion();
        for(int i = 0; i<answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = questionSO.GetAnswer(i);

        }
    }

    
}
