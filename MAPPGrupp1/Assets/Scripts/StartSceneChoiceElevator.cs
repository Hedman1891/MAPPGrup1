using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChoiceElevator : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(8);
    }
}
