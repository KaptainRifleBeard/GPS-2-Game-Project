using System;
using UnityEngine.Audio;
using UnityEngine;

public class SettingAudio : MonoBehaviour
{
    _Sound[] sounds;

    public void TurnOn_SFX()
    {
    }

    public void TurnOff_SFX()
    {

    }

    public void TurnOn_BGM()
    {
        _Sound s = Array.Find(sounds, sound => sound.name == "BGM");
        s.source.volume = 0.5f;

    }
    public void TurnOff_BGM()
    {
        _Sound s = Array.Find(sounds, sound => sound.name == "BGM");
        s.source.volume = 0;
    }


    public void Update()
    {
        
        
    }
}
