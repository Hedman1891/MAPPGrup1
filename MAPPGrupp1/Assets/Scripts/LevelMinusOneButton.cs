using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMinusOneButton : MonoBehaviour
{
    public void MinusOne()
    {
        SceneManager.LoadScene(4);
    }
}
