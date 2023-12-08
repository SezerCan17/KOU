using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private movment Movement;
	public int maxHealth = 100;
    int currentHealth;
	void Start()
	{
		currentHealth = maxHealth;
		Movement = GetComponent<movment>();
	}

	// Update is called once per frame
	void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
		Debug.Log("hasar aldýn");
		//hurt animation
		if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        //die animation
        Debug.Log("geberdin");
		Movement.enabled = false;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.CompareTag("enemies"))
        {
			TakeDamage(20);
		}
                   
	}
}
