using System;
using UnityEngine.Audio;
using UnityEngine;

public class _AudioManager : MonoBehaviour
{
    public _Sound[] sounds;
    public static _AudioManager instance;

    public int number;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        foreach (_Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volumn;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }


    public void Play(string name, float vol)
    {
        _Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Play();
        s.source.volume = vol;

    }

    void Start()
    {
        Play("BGM", 0.5f);
    }

    void Update()
    {
        number = SettingAudio.bgmnum;

        //if (number == 0)
        //{
        //    Play("BGM", 0.0f);
        //}
        //if (number == 1)
        //{
        //    Play("BGM", 0.5f);
        //}
    }
}



