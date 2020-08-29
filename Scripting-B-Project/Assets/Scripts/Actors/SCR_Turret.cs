using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Turret : SCR_Actors
{
    public GameObject target;

    public float rotationSpeed;

    public int exp;

    // Update is called once per frame
    void Update()
    {
        Turn();
    }

    public void Turn()
    {
        if (target == null)
        {
            rb.angularVelocity = rotationSpeed;
            return;
        }
        Vector3 targetDir = target.transform.position - transform.position;
        float angle = Vector3.SignedAngle(targetDir, transform.up, transform.forward);
        if (angle > 0)
        {
            rb.angularVelocity = -rotationSpeed;
        }
        else
        {
            rb.angularVelocity = rotationSpeed;
        }
        if (angle < 10 && angle > -10)
        {
            Fire(this.gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            target = null;
        }
    }

    public override void RemoveHealth(int damage, GameObject damager)
    {
        health -= damage;
        if (health <= 0)
        {
            damager.GetComponent<SCR_PlayerLevel>().AddExp(exp);
            Destroy(this.gameObject);
        }
    }
}
