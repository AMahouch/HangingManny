using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class VolumeSetting : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider volumeSlider;
    public float MusicVolume = 1f;
    public AudioMixer audioMixer;


    public void Start()
    {
        //MusicVolume = PlayerPrefs.GetFloat("volume");DELETE THIS LINE AND NEXT
        //volumeSlider.value = PlayerPrefs.GetFloat("volume");
        Debug.Log("The mixer value is: " + PlayerPrefs.GetFloat("volume"));
        MusicVolume = PlayerPrefs.GetFloat("volume");
        Debug.Log(volumeSlider.value);
    }
    
    
    //hook audoMixer to the volume
    public void SetVolume (float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
        MusicVolume = volume;
    }
}
