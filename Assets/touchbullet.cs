using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchbullet : MonoBehaviour
{
	public GameObject newtree;
	public counter counter_;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.CompareTag("treebullet"))
		{
			//gameObject.boxColider2D.enable = false;
            Destroy(gameObject);
			counter_._counter();
            newtree.SetActive(true);
			
		}
	}
}
