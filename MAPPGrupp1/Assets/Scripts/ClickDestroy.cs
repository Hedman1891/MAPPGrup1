using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public void DestroyThisObject()
{
   Destroy(gameObject);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
