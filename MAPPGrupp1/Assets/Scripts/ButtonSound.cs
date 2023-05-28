using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
  public void PlayButtonSound()
    {

        audioSource.PlayOneShot(audioClip);
    }
}
