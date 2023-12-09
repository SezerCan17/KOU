using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public SpriteRenderer render;
    public Color newColor1;
	public Color newColor2;

	private HealtBar healtbar;
 
	Vector2 checkPointPos;

	private movment Movement;
	public int maxHealth = 100;
    int currentHealth;
    public HealtBar healthbar;
	void Start()
	{
		currentHealth = maxHealth;
		Movement = GetComponent<movment>();
        render = GetComponent<SpriteRenderer>();

		checkPointPos = transform.position;
	}

	// Update is called once per frame
	void Update()
    {
		
	}
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);

		Debug.Log("hasar ald�n");
		//hurt animation
		if (currentHealth <= 0)
        {
			
			Die();
			currentHealth = maxHealth;
			healthbar.slider.value = 100;

		}
    }
    public void Die()
    {
        //die animation
        Debug.Log("geberdin");
		//Movement.enabled = false;
		//GetComponent<Collider2D>().enabled = false;
		//this.enabled = false;
		transform.position = checkPointPos;
		
	}
	public void UpdateCheckpoint(Vector2 pos)
	{
		checkPointPos = pos;
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.CompareTag("enemies"))
        {
			TakeDamage(20);
            render.color = newColor1;
			
		}   
       
	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("enemies"))
		{
			render.color = newColor2;
		}

	}
}
