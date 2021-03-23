using System;
using UnityEngine.Audio;
using UnityEngine;

public class _AudioManager : MonoBehaviour
{
    public _Sound[] sounds;
    public static _AudioManager instance;

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


    public void Play(string name)
    {
        _Sound s = Array.Find(sounds, sound => sound.name == name);


        s.source.Play();
    }

    void Start()
    {
        Play("BGM");
    }


}



