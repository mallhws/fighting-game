using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
	public float launchForce = 5f;
	
	public float explodeRange = 2f;
	public LayerMask mask;
	public GameObject effect;
	
	public void Update()
	{
		
	}
    public void launch(string direction)
	{
		if(direction == "left")
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-1,0) * launchForce, ForceMode2D.Impulse);
		}else{
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * launchForce, ForceMode2D.Impulse);
			
		}
	}
	
	public void explode()
	{
			Collider2D[] objs = Physics2D.OverlapCircleAll(transform.position, explodeRange, mask);
			foreach(var obj in  objs)
			{
				if(obj.CompareTag("Player"))
				{	
					//damage players in circle
				}
			}
			Instantiate(effect,transform.position, Quaternion.identity);
		
		Destroy(gameObject);
	}
	public void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, explodeRange);
	}
	
	public void OnCollisionEnter2D(Collision2D col)
	{
		explode();
	}
}
