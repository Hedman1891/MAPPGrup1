using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOff : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float disableDelay = 3f;

    private void Start()
    {
        StartCoroutine(DisableParticleEffect());
    }

    private IEnumerator DisableParticleEffect()
    {
        yield return new WaitForSeconds(disableDelay);
        particleSystem.Stop();
        
    }
}
