using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucket : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
       Debug.Log("touched bucket");
    }
}
