using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateScenes : MonoBehaviour
{ 
    //skriv namnet på scenen som det ska bytas till i Unity när man lägger till scriptet på knappen
    public void SwitchScene(string sceneName){
        SceneManager.LoadScene(sceneName);

        if (AudioPlayer.instance != null && sceneName == "MainMenu" || sceneName == "DoYouWannaPlay") {

            AudioPlayer.instance.GetComponent<AudioSource>().Stop();
        }

    else
    {
        AudioPlayer.instance.GetComponent<AudioSource>().Play();
        }

    }
    }

