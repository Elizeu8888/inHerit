using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Enemy
{

    void Start()
    {
        enemyHealth = 25f;
        enemySpeed = 12f;
        enemyDamage = 20f;
    }


    void Update()
    {
        LookAtPlayer();
    }
}
