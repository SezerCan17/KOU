using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
	public GameObject portal;
	private void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.CompareTag("bullet2"))
		{
			portal.SetActive(true);
			Destroy(collision.gameObject);

		}

	}
}
