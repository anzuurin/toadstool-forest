using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : Collidable
{

    private SpriteRenderer spriteRenderer; 
    private float cooldown = 0.5f; 
    private float lastSwing; 

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<spriteRenderer>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if(Input.GetKeyDown(KeyCode.Space)){
            if(Time.time - lastSwing > cooldown){
                lastSwing = Time.time; 
                Swing(); 
            }
        }
    }

	protected override void OnCollide(Collider2D coll)
	{
		base.OnCollide(coll);
        
	}

    private void Swing(){

    }
}
