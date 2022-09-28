using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 100f;
        enemySpeed = 15f;
        enemyDamage = 34f;
    }


    public override void LookAtPlayer()
    {
        print("Dragon is looking at player");
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }
}
