using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairwell_Down_Button : MonoBehaviour
{
    public void Down()
    {
        SceneManager.LoadScene(7);
    }
}
