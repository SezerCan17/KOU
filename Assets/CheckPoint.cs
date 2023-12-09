using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
	private PlayerHealth playerhealth;

	private Collider2D collider;
	void Start()
	{
		collider = GetComponent<Collider2D>();
	}
	private void Awake()
	{
		playerhealth = GameObject.FindGameObjectWithTag("player").GetComponent<PlayerHealth>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("player"))
		{
			playerhealth.UpdateCheckpoint(transform.position);
			collider.GetComponent<Collider2D>().enabled= false;
		}
	}
}
