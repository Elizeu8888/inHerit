using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 25f;
        enemySpeed = 12f;
        enemyDamage = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }
}
