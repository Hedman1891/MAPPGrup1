using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftButton : MonoBehaviour
{
    public void LeftChoice()
    {
        SceneManager.LoadScene(2);
    }
}

