using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucket : Collectable
{
    public Sprite emptyBucket;
    public int waterAmount = 1;

    protected override void OnCollect()
    {
       if(!collected)
       {
           collected = true;
           GetComponent<SpriteRenderer>().sprite = emptyBucket;
           Debug.Log("You have" + waterAmount + "water!");
       }
       
    //    base.OnCollide(); //collected = true;
       
    }
}
