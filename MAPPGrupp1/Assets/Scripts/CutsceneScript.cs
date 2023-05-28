using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutsceneScript : MonoBehaviour
{
    FadeInOut fade;
    public VideoPlayer videoPlayer;
    public string nextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<FadeInOut>();

        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Update is called once per frame
    void OnVideoEnd(VideoPlayer Player)
    {
        //Wait();
        fade.FadeIn();
        SceneManager.LoadScene(nextSceneName);
    }
    public IEnumerator Wait() {
        yield return new WaitForSeconds(4);
    }
}

