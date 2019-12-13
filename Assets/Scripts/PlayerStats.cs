using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    public PlayerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<PlayerMovement>();

        health = 10;
        maxhealth = 100;

        mana = 100;
        maxmana = 100;

        damage = 25;

        attackSpeed = 1f;
    }

    //If player dies, player can no longer move
    public override void Die()
    {
        movementScript.enabled = false;
    }
}
