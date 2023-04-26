using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stairwell_Up_Button : MonoBehaviour
{
    public void Up()
    {
        SceneManager.LoadScene(9);
    }
}
