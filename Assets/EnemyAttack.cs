using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Rigidbody2D rb;
	
	public Transform attackPoint;
	public float attackRange = 0.5f;
	public LayerMask playerLayer;
	float sayac = 1f;
	void Update()
	{
		if(rb.velocity.x<0.1 && rb.velocity.x > -0.1)
		{
			if (sayac < 0)
			{
				attack();
				sayac = 1f;
			}
			
		}
		sayac -= Time.deltaTime;
	}
	void attack()
	{
		

		Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
		foreach (Collider2D player in hitPlayer)
		{
			
			player.GetComponent<PlayerHealth>().TakeDamage(20);

		}
	}
	void OnDrawGizmosSelected()
	{
		if (attackPoint == null)
		{
			return;
		}
		Gizmos.DrawWireSphere(attackPoint.position, attackRange);

	}
}
