using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kokee_movement : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Vector3 moveDelta;

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
            transform.localScale = Vector3.one;
        else if(moveDelta.x <0)
            transform.localScale = new Vector3(-1,1,1);

        //make it move
        transform.Translate(moveDelta * Time.deltaTime);
    }
}

