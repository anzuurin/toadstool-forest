using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    //logic
    protected bool collected;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Melody")
            OnCollect();
    }

    protected virtual void OnCollect()
    {
        collected = true;
    }
}
