using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckPassword : MonoBehaviour
{
    // Start is called before the first frame update

    private InputField inputTextField;

    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }

    public void CheckPasswordAndLoadScene()
    {

    switch (inputTextField.text)

    {
        case "ESCAPE":
            SceneManager.LoadScene("EndingOneWin");
            break;
        
        default:
        inputTextField.text = "Wrong Password";
        break;
    }

    
    
}
}