using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public static GameAudio instance;

    
    [SerializeField] private AudioSource sfxAudio;
    [SerializeField] private AudioClip correctAnswerSFX;
    [SerializeField] private AudioClip wrongAnswerSFX;
    [SerializeField] private AudioClip timerSFX;


    private void Awake()
    {
        instance = this;
    }

    public void CorrectAnswerClickSFX() => sfxAudio.PlayOneShot(correctAnswerSFX);
    public void WrongAnswerClickSFX() => sfxAudio.PlayOneShot(wrongAnswerSFX);
    public void TimerClickSFX() => sfxAudio.PlayOneShot(timerSFX);
    public void StopTimerClickSFX() => sfxAudio.Stop();
    
}
