using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	
	public Collider2D col;

	public Rigidbody2D rb;

	public Animator animator;

	public SpriteRenderer render;
	public Color newColor1;
	public Color newColor2;
	void Start()
    {
		currentHealth = maxHealth;
		render = GetComponent<SpriteRenderer>();
	}
	void Update()
	{
		
			animator.SetFloat("speed", Mathf.Abs(rb.velocity.x));
		
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		render.color = newColor1;
		StartCoroutine(sayac());
		if (currentHealth <= 0)
		{
			//die animation
			Die();
            //Destroy(gameObject);
            Debug.Log("Öldü");
            gameObject.SetActive(false);
			

		}
	}
	public void Die()
	{
       
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("bullet"))
		{
			TakeDamage(10);
			render.color = newColor1;
			StartCoroutine(sayac());
		}
		
	}


	public IEnumerator sayac()
	{
		yield return new WaitForSeconds(0.2f);
		render.color = newColor2;
	}
}
