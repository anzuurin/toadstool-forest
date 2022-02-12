using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D fitler;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    proteced virtual void Update()
    {
        //collision work
        boxCollider.OverlapCollider(filter,hits);
        for (int i = 0, i < hits.len; i++)
        {
            if(hits[i] == null)
                continue;

            Debug.Log(hits[i].name);

            //array doesnt automatically clean up so we do it
        }
    }
}
