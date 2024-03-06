using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    public static MenuAudio instance;

    [SerializeField] private AudioSource backgroundAudio;
    [SerializeField] private AudioSource sfxAudio;
    [SerializeField] private AudioClip buttonClickSFX;


    private void Awake()
    {
        instance = this;
    }

    public void ButtonClickSFX() => sfxAudio.PlayOneShot(buttonClickSFX);
    public void MuteBackgroundAudio() => backgroundAudio.Pause();



}
