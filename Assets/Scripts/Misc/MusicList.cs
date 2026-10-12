using UnityEngine;
using System.Collections.Generic;

public class MusicList : MonoBehaviour
{
    public AudioClip[] MusicPlaylist;
    public bool shuffle = false;

    private int currentIndex = 0;
    private List<int> remaining = new List<int>();
    private bool isPaused = false;

    void Start()
    {
        if (MusicPlaylist.Length == 0) return;

        // The manager loops the clip by default if loop is on, so make sure it's off
        AudioManagerScript.Instance.MusicSource.loop = false;

        if (shuffle) currentIndex = Random.Range(0, MusicPlaylist.Length);
        PlayCurrent();
    }

    void Update()
    {
        if (MusicPlaylist.Length == 0 || isPaused) return;

        // Song finished, so move on
        if (!AudioManagerScript.Instance.MusicSource.isPlaying)
        {
            NextTrack();
        }
    }

    void PlayCurrent()
    {
        AudioManagerScript.Instance.PlayMusic(MusicPlaylist[currentIndex]);
    }

    public void NextTrack()
    {
        if (shuffle && MusicPlaylist.Length > 1)
        {
            if (remaining.Count == 0)
            {
                // Refill the bag, excluding the song that just played
                for (int i = 0; i < MusicPlaylist.Length; i++)
                    if (i != currentIndex) remaining.Add(i);
            }

            int pick = Random.Range(0, remaining.Count);
            currentIndex = remaining[pick];
            remaining.RemoveAt(pick);
        }
        else
        {
            currentIndex = (currentIndex + 1) % MusicPlaylist.Length;
        }

        PlayCurrent();
    }

    // Call these instead of pausing the AudioSource directly
    public void PauseMusic()
    {
        isPaused = true;
        AudioManagerScript.Instance.MusicSource.Pause();
    }

    public void ResumeMusic()
    {
        isPaused = false;
        AudioManagerScript.Instance.MusicSource.UnPause();
    }
}