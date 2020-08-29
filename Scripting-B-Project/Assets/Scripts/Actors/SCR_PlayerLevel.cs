using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerLevel : MonoBehaviour
{
    public int level;
    public int exp;

    public int skillPoints;

    public int armour;
    public int cannon;
    public int treads;

    public SCR_PlayerController player;
    public void Awake()
    {
        SCR_GameManager.LevelUp += LevelUp;
    }
    public void AddExp(int expIncrease)
    {
        exp += expIncrease;
        if (exp > level * 10)
        {
            SCR_GameManager.LevelUp();
        }
    }

    public void LevelUp()
    {
        level++;
        skillPoints++;
        exp -= level * 3;
    }

    public void ArmourIncrease()
    {
        if (skillPoints <= 0) return;
        skillPoints--;
        armour++;
        player.ChangeMaxHealth(10);
    }
    public void CannonIncrease()
    {
        if (skillPoints <= 0) return;
        skillPoints--; 
        cannon++;
        player.weapon.damage += 5;
    }
    public void TreadIncrease()
    {
        if (skillPoints <= 0) return;
        skillPoints--; 
        treads++;
        player.movementSpeed += 5;
        player.rotationSpeed += 2;
    }
}
