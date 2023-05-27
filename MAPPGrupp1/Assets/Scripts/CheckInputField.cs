using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInputField : MonoBehaviour
{
    // Start is called before the first frame update
     public CheckPassword checkPasswordScript;

    public void OnCheckButtonClick()
    {
        checkPasswordScript.CheckPasswordAndLoadScene();
    }
}
