using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float enemyHealth = 0f;
    public float enemySpeed = 0f;
    public float enemyDamage = 0f;


    void Start()
    {
        
    }


    public virtual void LookAtPlayer()
    {
        print("Enemy is Looking at player");
    }

}
