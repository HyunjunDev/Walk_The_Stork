using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    private AudioSource bgmSound;
    private AudioSource sfxSound;

    private void Awake()
    {
        bgmSound = GameObject.Find("BGMSoundPlayer").GetComponent<AudioSource>();
        sfxSound = GameObject.Find("SFXSoundPlayer").GetComponent<AudioSource>();
        EventManager.DieEvent += PlaySFXSound;
        EventManager.StartEvent += PlayBGMSound;
    }

    public void PlayBGMSound()
    {
        bgmSound.loop = true;
        bgmSound.Play();
    }

    public void PlaySFXSound()
    {
        bgmSound.Stop();
        sfxSound.Play();
    }
}
