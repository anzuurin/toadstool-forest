using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A collidable requires the parent object to have a BoxCollider2D, which could be accomplished with the following
// [RequireComponent(typeof(BoxCollider2D))]
public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        //collision work
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if(hits[i] == null)
                continue;

            OnCollide(hits[i]);

            //array doesnt automatically clean up so we do it
            hits[i] = null;
        }
    }
    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }
}
