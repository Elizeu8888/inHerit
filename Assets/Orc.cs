using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 7f;
        enemySpeed = 3f;
        enemyDamage = 14f;
    }



    public override void LookAtPlayer()
    {
        print("Orc is looking at player");
    }


    void Update()
    {
        LookAtPlayer();
    }
}
