using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
	public GameObject portal;
	public GameObject portal2;
	public GameObject portal3;
	private void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.CompareTag("bullet2"))
		{
			portal.SetActive(true);
			portal2.SetActive(true);
			portal3.SetActive(true);
			Destroy(collision.gameObject);

		}

	}
}
