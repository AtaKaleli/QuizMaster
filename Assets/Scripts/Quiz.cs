using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{


    [SerializeField] private QuestionSO questionSO;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private GameObject[] answerButtons;

    private int correctAnswerIdx;
    [SerializeField] private Sprite defaultAnswerSprite;
    [SerializeField] private Sprite correctAnswerSprite;

    void Start()
    {
        GetNextQuestion();
    }



    private void GetNextQuestion()
    {
        SetButtonState(true);
        DisplayQuestion();
        SetDefaultButtonSprite();
        
    }

    private void SetDefaultButtonSprite()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            Image image = answerButtons[i].GetComponent<Image>();
            image.sprite = defaultAnswerSprite;

        }
    }

    private void DisplayQuestion()
    {
        questionText.text = questionSO.GetQuestion();
        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = questionSO.GetAnswer(i);

        }
        
    }

    public void OnAnswerSelected(int index)
    {
        if(index == questionSO.GetCorrectAnswerIdx())
        {
            questionText.text = "Correct";
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIdx = questionSO.GetCorrectAnswerIdx();
            int correctOption = correctAnswerIdx + 1;
            questionText.text = "False! Correct answer is option " + correctOption;
            Image buttonImage = answerButtons[correctAnswerIdx].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;

        }
        SetButtonState(false);
    }


    private void SetButtonState(bool state)
    {
        for(int i = 0; i< answerButtons.Length; i++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }

    
}
