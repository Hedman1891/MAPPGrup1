using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
}
