using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using HoloToolkit.Unity;

public class GameController : Singleton<GameController>
{
    private bool tourOver;
    private int exhibitCount;
    public GUIText tourOverText;

    void Start()
    {
        tourOver = false;
        exhibitCount = 0;
        tourOverText.text = "";
    }

    public void addExhibit()
    {
        if (tourOver != true)
        {
            exhibitCount += 1;
            TourOver();
        }
    }

    public void TourOver()
    {
        if (exhibitCount > 5)
        {
            Camera.main.GetComponent<AudioSource>().Play();
            tourOverText.text = "Tour Over!";
            tourOver = true;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Camera.main.GetComponent<AudioSource>().Pause();
    }

    public void Help()
    {
        //insert commands to play help audio
    }
}