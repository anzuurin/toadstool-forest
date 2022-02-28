using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Collidable
{
    protected bool collected; 
  
    protected override void OnCollide(Collider2D coll){
        Debug.Log("collectible is colliding");
        if(coll.name == "Melody")
            OnCollect(); 
    }

    protected virtual void OnCollect(){
        collected = true; 
    }
}
