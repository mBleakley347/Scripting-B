using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Projectile : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    public float lifeTime;

    public int damage;

    public GameObject origin;
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        rb.AddForce(transform.up * speed);
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0) Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (origin == other.gameObject) return;
        if (other.tag == this.tag) return;
        if (other.isTrigger) return;
        if (other.GetComponent<SCR_Destructable>() != null)
        {
            other.GetComponent<SCR_Destructable>().RemoveHealth(damage, origin);
        }
        Destroy(this.gameObject);
    }
}
