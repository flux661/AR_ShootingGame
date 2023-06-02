using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgm_sync : MonoBehaviour
{
    //public GameObject bgmobject;
   // public  AudioSource bgm_audio;
        
    public AudioSource musicsource;
    public float vol = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        //bgmobject = GameObject.FindWithTag("BGM");
        //bgm_audio = bgmobject.GetComponent<AudioSource>();
       musicsource.Play();
        

        
    }
    void Update()
    {
        musicsource.volume = vol;
    }
     public void Volupdate(float value)
    {
        vol = value;
    }

    
}
