using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource EffectsSource;
    public AudioSource MusicSource;
    public AudioClip AlarmSource;

    public static bool IsTriggered = false;
    // need to replace with a global GameLost Trigger, game lost trigger will have to be returned to false after menu pops up

    public float LowPitchRange = .95f;
    public float HighPitchRange = 1.05f;

    public static AudioManager Instance = null;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            PlayAlarm(AlarmSource);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Play(AudioClip clip)
    {
        if (PlayerPrefs.GetInt("SFX") == 1 || PlayerPrefs.GetInt("SFX") == 0)
        {
            EffectsSource.clip = clip;
            EffectsSource.Play();
        }
        else if (PlayerPrefs.GetInt("SFX")== -1)
        {
            EffectsSource.Stop();
        }
    }

    public void PlayAlarm(AudioClip clip)
    {
        

        if (IsTriggered == true)
        {
            MusicSource.clip = clip;
            MusicSource.Play();
        }
        else if (IsTriggered == false && MusicSource.isPlaying == true)
        {
            MusicSource.Stop();
        }
            
        
    }


    public void PlayMusic(AudioClip clip)
    {
        if (PlayerPrefs.GetInt("BGM") == 1 || PlayerPrefs.GetInt("BGM") ==0)
        {
            MusicSource.clip = clip;
            MusicSource.Play();
        }
        else if (PlayerPrefs.GetInt("BGM") == -1)
        {
            MusicSource.Stop();
        }
    }

    public void RandomSoundEffect(params AudioClip[] clips)
    {
        int randomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(LowPitchRange, HighPitchRange);

        EffectsSource.pitch = randomPitch;
        EffectsSource.clip = clips[randomIndex];
        EffectsSource.Play();
    }

}
