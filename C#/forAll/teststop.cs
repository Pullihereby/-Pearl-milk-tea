using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teststop : MonoBehaviour
{
    private AudioSource bgMusicAudioSource;

    public GameObject stop;
    public GameObject conti;
    public GameObject ex;
    public GameObject bk;
    void Start()
    {
        
    }

    public void ClickStop()
    {
        stop.SetActive(true);
        conti.SetActive(true);
        ex.SetActive(true);
        bk.SetActive(true);
        Time.timeScale = 0f;
        //在所有Game Object中找尋Background Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("Background Music").GetComponent<AudioSource>(); 
        //暫停音樂
        bgMusicAudioSource.Pause();

    }

    public void Clickconti()
    {
        stop.SetActive(false);
        conti.SetActive(false);
        ex.SetActive(false);
        bk.SetActive(false);
        Time.timeScale = 1f;
        //繼續音樂
        bgMusicAudioSource.UnPause();
    }

    public void Clickex()
    {
        Application.LoadLevel("Map");
    }
}