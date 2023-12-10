using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeupgrade : MonoBehaviour
{
	private bool temasvar = false;
	public Weapon weapon;
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			treeupgrade_();

		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "player")
		{
			temasvar = true;
		}
	}
	public void treeupgrade_()
	{
		if (temasvar)
		{
			weapon.canUse = true;
			gameObject.SetActive(false);
			
		}
		
	}
}
