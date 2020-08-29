using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_EndZone : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SCR_GameManager.instance.EndScene();
        }
    }
}
