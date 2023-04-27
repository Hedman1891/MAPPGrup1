using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneButton : MonoBehaviour
{
    public void One()
    {
        SceneManager.LoadScene(3);
    }
}
