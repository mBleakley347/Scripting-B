using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_MusicTrackHolder : MonoBehaviour
{
    public static SCR_MusicTrackHolder instance;
    public AudioClip[] music;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;   
    }
}
