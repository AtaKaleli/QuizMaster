using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{

    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject howToPlay;
    [SerializeField] private GameObject credits;
    
    IEnumerator StartTheGame()
    {
        yield return new WaitForSeconds(.5f);
        SceneManager.LoadScene("Game");
    }

    public void OnClickStartGame()
    {

        StartCoroutine(StartTheGame());

    }
    public void OnClickHowToPlay()
    {
        MenuAudio.instance.ButtonClickSFX();
        menu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void OnClickCredits()
    {
        MenuAudio.instance.ButtonClickSFX();
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickBackFromCredits()
    {
        MenuAudio.instance.ButtonClickSFX();
        menu.SetActive(true);
        credits.SetActive(false);
    }

    public void OnClickBackFromHTP()
    {
        MenuAudio.instance.ButtonClickSFX();
        menu.SetActive(true);
        howToPlay.SetActive(false);
    }



}