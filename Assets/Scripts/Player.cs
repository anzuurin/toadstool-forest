using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        //resets movedelta
        moveDelta = new Vector3(x,y,0);

        //swap sprite direction if ur going right or left
        if(moveDelta.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1.0f);
        else if(moveDelta.x <0)
            transform.localScale = new Vector3(-1f,1f,1.0f);

        //making sure we can move in this direction by casting box there first, if its null, we can move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));
        if (hit.collider == null)
        {
        //make it move
        transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }

        //for x axis
        hit = Physics2D.BoxCast(transform.position,boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));
        if (hit.collider == null)
        {
        //make it move
        transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }

    }
}

