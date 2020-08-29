using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SoundEffects : MonoBehaviour
{
    public static SCR_SoundEffects instance;

    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void Play(AudioClip clip)
    {
        audio.clip = clip;
        audio.Play();
    }
}
