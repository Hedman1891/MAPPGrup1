using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChoice : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(6);
    }
}

