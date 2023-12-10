using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnSkill : MonoBehaviour
{
	public bool onbook = false;

	void Start()
	{
		GetComponent<Atack2>().enabled = false;
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && onbook)
		{
			Debug.Log("book1");
			GetComponent<Atack2>().enabled = true;
			
			this.enabled = false;
		}
		
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
	
		if (collision.gameObject.tag=="book1")
		{
			onbook = true;
		}
		
	}
	private void OnTriggerExit2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "book1")
		{
			onbook = false;
		}

	}
}
