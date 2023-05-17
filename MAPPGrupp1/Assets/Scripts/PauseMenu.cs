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
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;

    void Start()
    {
        PauseMenuWindow.SetActive(false);

        //GameObject.Find(videoPlayer);
        //VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) /* eller framtida pause ikon klickas*/)
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
        Button1.gameObject.SetActive(true);
        Button2.gameObject.SetActive(true);
        //Button3.gameObject.SetActive(true);
        //Button4.gameObject.SetActive(true);
    }

    public void Pause()
    {
        videoPlayer.Pause();
        PauseMenuWindow.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
        //Button3.gameObject.SetActive(false);
        //Button4.gameObject.SetActive(false);
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
    }

    public void LoadSettings()
    {
        Debug.Log("Loading Settings...");
    }
}
