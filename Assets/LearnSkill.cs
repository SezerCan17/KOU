using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnSkill : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnTriggerStay2D(Collider2D collision)
	{
	
		if (collision.gameObject.tag=="book1")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				Debug.Log("book1");
			}
		}
	}
}
