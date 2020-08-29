using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Triggers : MonoBehaviour
{
    public bool infinate;
    public AudioClip clip;
   public void OnTriggerEnter2D(Collider2D other)
    {
        Effect(other);
    }

    public virtual void Effect(Collider2D other)
    {
        SCR_SoundEffects.instance.Play(clip);
        if (!infinate) Destroy(this.gameObject);
    }
}
