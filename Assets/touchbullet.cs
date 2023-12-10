using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchbullet : MonoBehaviour
{
	public GameObject newtree;
	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.CompareTag("treebullet"))
		{
			Destroy(gameObject);
			newtree.SetActive(true);
		}
	}
}
