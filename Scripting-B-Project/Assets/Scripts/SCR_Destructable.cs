using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Destructable : MonoBehaviour
{
    [Header("Health")]
    public int health;
    public int maxHealth;
    public bool maxed;

    void Start()
    {
        StartFunction();
    }

    public virtual void StartFunction()
    {
        if (maxHealth == 0) maxHealth = health;
    }
    public virtual void RemoveHealth(int damage)
    {
        health -= damage;
        if (health <= 0) Destroy(this.gameObject);
    }
    public virtual void RemoveHealth(int damage , GameObject damager)
    {
        health -= damage;
        if (health <= 0) Destroy(this.gameObject);
    }
    public virtual void AddHealth(int heal)
    {
        health += heal;
        if (maxed)
        {
            if (health > maxHealth) health = maxHealth;
        }
    }
}
