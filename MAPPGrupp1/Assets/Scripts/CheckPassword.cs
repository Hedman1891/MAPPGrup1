using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckPassword : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField inputTextField;
    public Light[] pointLights;

    public void CheckPasswordAndLoadScene()
    {
        switch (inputTextField.text)
        {
            case "ESCAPE":
                SceneManager.LoadScene("Garage_Correct_Ending");
                break;

            default:
                inputTextField.text = "Wrong Password";
                DisablePointLights();
                break;
        }
    }

    private void DisablePointLights()
    {
        foreach (Light pointLight in pointLights)
        {
            if (pointLight != null)
            {
                pointLight.enabled = false;
            }
        }
    }
}
