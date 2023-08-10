using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : Singleton<SoundController>
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource effectSource;

    public void PlaySound(AudioClip clip)
    {
        effectSource.PlayOneShot(clip);
    }
    /*public void PlayBGMusic(AudioClip clip)
    {
        musicSource.Play(clip);
    }*/
    public void ChangeMasterVolume(float volume)
    {
        AudioListener.volume = volume;
    }
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }
    public void ToggleEffect()
    {
        effectSource.mute = !effectSource.mute;
    }
}
