using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volume_setter : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Slider volslider;
    public float val;

    public void Start()
    {
        audiomixer.GetFloat("volume",out val);
        volslider.value = val;
    }
    public void Volsetter(float slider)
    {
        audiomixer.SetFloat("Audio_volume", Mathf.Log10(slider) * 20);
    }
}
