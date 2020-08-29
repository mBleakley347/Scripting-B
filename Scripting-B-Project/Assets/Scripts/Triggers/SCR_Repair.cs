using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Repair : SCR_Triggers
{
    public int amount;
    public override void Effect(Collider2D other)
    {
        //check if player has collided with object and heal them the amount
        if (other.tag == "Player")
        {
            other.GetComponent<SCR_PlayerController>().AddHealth(amount);
            base.Effect(other);
        }
    }
}
