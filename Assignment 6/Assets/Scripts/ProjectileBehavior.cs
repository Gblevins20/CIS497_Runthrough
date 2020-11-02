/*
 * Gregory Blevins
 * Assignment 6
 * Handles Projectile Spawning for Shooter Enemies
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : Enemy
{
    protected override void Attack()
    {
        GameManager.Instance.health -= 2;
        Destroy(gameObject);
    }

    protected override void Movement()
    {
        transform.Translate(-3f * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon") && (collision.transform.rotation.x == 0))
        {
            Destroy(gameObject);
        }
        else
        {
          Attack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
