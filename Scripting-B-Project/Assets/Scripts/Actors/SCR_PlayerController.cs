using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerController : SCR_Actors
{
    [Header("Movement")]
    public float movementSpeed;
    public float rotationSpeed;

    public override void StartFunction()
    {
        base.StartFunction();
        /*SCR_GameManager.HealthChange(health);
        SCR_GameManager.HealthMaxChange(maxHealth);*/
    }
    public void Update()
    {
        Movement();
        Rotate();
        if (Input.GetKeyDown(KeyCode.Space)) weapon.Fire(this.gameObject);
        SCR_GameManager.HealthChange(health);
        SCR_GameManager.HealthMaxChange(maxHealth);
    }

    public void Movement()
    {
        rb.AddForce(transform.up * movementSpeed * Input.GetAxis("Vertical"),ForceMode2D.Force);
        rb.AddForce(transform.right * movementSpeed * Input.GetAxis("Strafe") / 2, ForceMode2D.Force);
        rb.velocity = Vector2.zero;
    }

    public void Rotate()
    {
        rb.AddTorque(-rotationSpeed * Input.GetAxis("Horizontal"));
        rb.angularVelocity = 0;
    }

    public override void AddHealth(int heal)
    {
        base.AddHealth(heal);
        SCR_GameManager.HealthChange(health);
    }

    public override void RemoveHealth(int damage)
    {
        base.RemoveHealth(damage);
        SCR_GameManager.HealthChange(health);
    }

    public void ChangeMaxHealth(int change)
    {
        maxHealth += change;
        SCR_GameManager.HealthMaxChange(maxHealth);
    }
}
