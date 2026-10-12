using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioTest : MonoBehaviour
{
    public AudioClip DeathSound;

    private void Start()
    {
        AudioManagerScript.Instance.Play(DeathSound);
    }
}
