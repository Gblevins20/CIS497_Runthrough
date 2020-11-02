/*
 * Gregory Blevins
 * Assignment 6
 * Handles Ranged Varient of Enemies
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterFoe : Enemy, OutOfBounds
{
    public GameObject projectile;

    protected override void Attack()
    {
        Instantiate(projectile);
    }

    protected override void Movement()
    {
        transform.Translate(-1*Time.deltaTime, 0, 0);
    }

    protected override void Awake()
    {
        base.Awake();
        type = 2;
        score = 2;
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
    }

    public void OutOfBounds()
    {
        if (transform.position.x == -10)
        {
            Destroy(gameObject);
        }
    }
}
