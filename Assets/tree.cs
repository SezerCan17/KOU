using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
	
	public float speed = 20f;
	public Rigidbody2D rb;
	void Start()
	{
		rb.velocity = transform.right * speed;
	}
	void Update()
	{
		Destroy(gameObject, 1f);
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
	
		if (collision.gameObject.CompareTag("tree"))
		{
			Destroy(gameObject);
			
		}
	}
}
