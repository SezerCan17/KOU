using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalVisible : MonoBehaviour
{
	public SpriteRenderer render;

	public Weapon portalg;

	void Start()
	{
			render.enabled = false;
	}

	void Update()
    {
		//if (portalg.openportal == true)
		//{
		//	//render.enabled = true;
		//}
    }
	public void deneme()
	{
		render.enabled = true;
	}
}
