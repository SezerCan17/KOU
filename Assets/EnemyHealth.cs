using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	
	public Collider2D col;

	void Start()
    {
		currentHealth = maxHealth;
	
	}
	
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		if (currentHealth <= 0)
		{
			//die animation
			Die();
			gameObject.SetActive(false);
			

		}
	}
	private void Die()
	{

	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("bullet"))
		{
			TakeDamage(10);

		}
		
	}
	
}
