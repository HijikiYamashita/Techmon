using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScripts : MonoBehaviour
{
    private static bool isCreated = false;

    void Start()
    {
        if (isCreated)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            isCreated = true;
        }
    }

    void Update()
    {
        
    }
}