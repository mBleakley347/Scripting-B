using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Weapon : MonoBehaviour
{
    public GameObject projectile;
    public int damage;

    private float coolDown;
    public float coolDownTime;
    public void Update()
    {
        coolDown -= Time.deltaTime;
    }
    public virtual void Fire(GameObject origin)
    {
        
        if (coolDown >= 0) return;
        var temp = Instantiate(projectile, this.transform.position, transform.rotation);
        temp.GetComponent<SCR_Projectile>().origin = origin;
        temp.GetComponent<SCR_Projectile>().damage = damage;
        coolDown = coolDownTime;
    }
}
