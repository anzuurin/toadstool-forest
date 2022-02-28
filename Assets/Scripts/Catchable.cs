using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Catchable : Collidable
{
    protected float healthPoint = 3; 

    protected virtual void ReceiveDamage(float damagePoint){
        healthPoint -= damagePoint; 
        if(healthPoint <= 0) Death(); 
    
    }

    protected virtual void Death(){
        Destroy(gameObject);
    }
}
