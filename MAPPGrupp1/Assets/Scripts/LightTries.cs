using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightTries : MonoBehaviour

{
    public Light pointLight;
    public string userInputText;

    // Call this function to check the user input and disable the Point Light if it matches
    public void CheckAndDisable()
    {
        if (userInputText == "Wrong Password" && pointLight != null)
        {
            pointLight.enabled = false;
        }
    }
}
