using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;



public class PauseMenu : MonoBehaviour
{
    
    public static bool GameIsPaused = false;
    public GameObject PauseMenuWindow;
    public VideoPlayer videoPlayer;

    //Fält i unity för att länka och sedan dölja/visa valknappar vid pause
    public Button PauseKnapp;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;

    public List<Button> buttonList = new List<Button>();

    

    void Start()
    {
        PauseMenuWindow.SetActive(false);
        buttonList.Add(PauseKnapp);
        buttonList.Add(Button1);
        buttonList.Add(Button2);
        buttonList.Add(Button3);
        buttonList.Add(Button4);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) /* eller ev. om pause ikon klickas...*/)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else {
                Pause();
            }
        } 
    }

    public void Resume()
    {
        videoPlayer.Play();
        PauseMenuWindow.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        for (int i = 0; i < buttonList.Count; i++)
        {
            if (buttonList[i] != null)
            {
                buttonList[i].gameObject.SetActive(true);
            }
        }
    }

    public void Pause()
    {
        videoPlayer.Pause();
        AudioPlayer.instance.GetComponent<AudioSource>().Pause();
        PauseMenuWindow.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        for (int i = 0; i < buttonList.Count; i++)
        {
            if (buttonList[i] != null)
            {
                buttonList[i].gameObject.SetActive(false);
            }
        }

    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        
    }

}
