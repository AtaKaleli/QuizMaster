using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] private float timeToCompleteQuestion;
    [SerializeField] private float timeToShowAnswer;
    private float timer;
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    public bool loadNextQuestion;


    private void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timer = 0;
    }

    private void UpdateTimer()
    {
        timer -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if(timer > 0)
            {
                fillFraction = timer / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timer = timeToShowAnswer;
            }
        }
        else
        {
            if (timer > 0)
            {
                fillFraction = timer / timeToShowAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timer = timeToCompleteQuestion;
                loadNextQuestion = true;

            }
        }

       
    }

}
