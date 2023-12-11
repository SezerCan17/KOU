using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   
	public int numOfHearths;
	private int i=2;
	public GameObject[] hearts;

	public Rigidbody2D rb;
	public Animator myanims;


	public int dieCounter=0;
	
	
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
		rb.velocity = new Vector2(15f, 15f);
		healthbar.SetHealth(currentHealth);

		Debug.Log("hasar aldýn");
		//hurt animation
		if (currentHealth <= 0)
        {
			Destroy(hearts[i]);
			i--;
			Die();

			currentHealth = maxHealth;
			healthbar.slider.value = 100;

		}
    }
    public void Die()
    {
        //die animation
        Debug.Log("geberdin");
		dieCounter++;
		if( dieCounter == 3 ) 
		{
            StartCoroutine(olmeTime());
            
		}
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

	public IEnumerator olmeTime()
	{
        myanims.SetTrigger("die");
        yield return new WaitForSeconds(1.25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
}
