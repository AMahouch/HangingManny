using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false;

    void Start()
    {
        UpdateButtonIcon();
        if(AudioListener.pause == true)
        {
            muted = true;
            UpdateButtonIcon();
        }
        else
        {
            muted = false;
            UpdateButtonIcon();
        }
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
    }

    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    //if muted = 1 then true and if muted = 0 then false
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    //if muted = true, save it as 1 and if muted = false, save it as 0
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

}
