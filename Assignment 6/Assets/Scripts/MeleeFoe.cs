/*
 * Gregory Blevins
 * Assignment 6
 * Melee Enemy Varient
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeFoe : Enemy, OutOfBounds
{
    bool dealtDamage;

    protected override void Attack()
    {
        GameManager.Instance.health -= 1;
    }

    protected override void Movement()
    {
        transform.Translate(-2 * Time.deltaTime, 0, 0);
    }

    protected override void Awake()
    {
        base.Awake();
        type = 1;
        score = 1;

        dealtDamage = false;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon") && (collision.transform.rotation.x == 90))
        {
            GameManager.Instance.score += score;
            Destroy(gameObject);
        }
        else
        {
            if (dealtDamage == false)
            {
                Attack();
            }
            dealtDamage = true;
        }
    }

    public void OutOfBounds()
    {
        if (transform.position.x == -10)
        {
            Destroy(gameObject);
        }
    }
}
