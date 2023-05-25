using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool fadeIn = false;
    public bool fadeOut = false;
    public float TimeToFade = 1f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (fadeIn == true)
        {
            if (canvasGroup.alpha < 1)
            {

                canvasGroup.alpha += TimeToFade * Time.fixedDeltaTime;
                if (canvasGroup.alpha >= 1)
                {
                    fadeIn = false;

                }
            }

        }
        if (fadeOut == true)
        {
            if (canvasGroup.alpha >= 0)
            {

                canvasGroup.alpha -= TimeToFade * Time.fixedDeltaTime;
                if (canvasGroup.alpha == 0)
                {
                    fadeOut = false;

                }
            }

        }
    }
    public void FadeIn(){
        fadeIn = true;
    }
    public void FadeOut() {
        fadeOut = true;
    }
}
            
        
        
    

