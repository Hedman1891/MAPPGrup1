using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoLeft : MonoBehaviour
{
    public void Left() {
        SceneManager.LoadScene(2);
    }
}
