using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
	public float sayac;
	// Update is called once per frame
	
		void Update()
	 {
		sayac -= Time.deltaTime;
		if (Input.GetButtonDown("Fire1"))
		{
			if(sayac < 0)
			{
				Shoot();
				sayac = 5f;
			}
			

		}
	}

	void Shoot()
    {
		
		Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
		
	}
    
}
