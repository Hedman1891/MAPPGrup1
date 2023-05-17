using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutsceneScript : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string nextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Update is called once per frame
    void OnVideoEnd(VideoPlayer Player)
    {
        SceneManager.LoadScene(nextSceneName);
    }

}

