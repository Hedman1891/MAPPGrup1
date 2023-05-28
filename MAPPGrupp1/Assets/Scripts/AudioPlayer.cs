using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static AudioPlayer instance;
void Awake() 
{
    if (instance != null){
        Destroy(gameObject);
    }
    else
    {
       instance = this;
       DontDestroyOnLoad(this.gameObject); 
    }

}
}
