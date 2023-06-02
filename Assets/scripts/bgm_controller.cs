using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bgm_controller : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] audioobject = GameObject.FindGameObjectsWithTag("BGM");

        if(audioobject.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    
   
}
