using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiveUp : MonoBehaviour
{
    public void GameOver() 
    {
        SceneManager.LoadScene(10);
    }
}
