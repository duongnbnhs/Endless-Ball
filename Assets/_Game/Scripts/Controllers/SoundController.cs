using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : Singleton<SoundController>
{
    public AudioSource soundSource;
    
    public void PlaySound(AudioClip sound)
    {
        soundSource.PlayOneShot(sound);
    }
}
