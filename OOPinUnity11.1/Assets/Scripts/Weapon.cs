/*
 * Gregory Blevins
 * Assignment 6
 * Handles Weapon Behaviour
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy weilder;

    private void Awake()
    {
        weilder = gameObject.GetComponent<Enemy>();
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon");
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy Eats Weapon");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
