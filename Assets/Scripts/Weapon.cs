using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable
{

    public float damagePoint = 1.0f; 

    private SpriteRenderer spriteRenderer; 
    private float cooldown = 0.5f; 
    private float lastSwing; 

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        if(coll.tag == "Catchable"){
            coll.SendMessage("ReceiveDamage", damagePoint);
        }
        
	}

    private void Swing(){

    }
}
