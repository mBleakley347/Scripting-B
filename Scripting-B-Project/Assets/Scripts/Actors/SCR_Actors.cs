using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Actors : SCR_Destructable
{
    [Header("Actor")]
    public Rigidbody2D rb;

    public SCR_Weapon weapon;

    public virtual void Fire(GameObject origin)
    {
        if (weapon != null)
        {
            weapon.Fire(origin);
        }
    }
}
