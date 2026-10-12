using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource EffectsSource;
    public AudioSource MusicSource;

    public static AudioManagerScript Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject.transform);
    }

    public void Play(AudioClip clip)
    {
        EffectsSource.clip = clip;
        EffectsSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
}
