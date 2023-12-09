using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
	public float sayac;

	public float sayac2;
	public GameObject bulletPrefab2;
	// Update is called once per frame

	public bool openportal = false;

	void Update()
	 {
		
		if (Input.GetButtonDown("Fire1"))
		{
			if(sayac < 0)
			{
				Shoot();
				sayac = 5f;
			}
			

		}
		sayac -= Time.deltaTime;
		if(Input.GetButtonDown("Fire2"))
		{
			if (sayac2 < 0)
			{
				Shoot2();
				sayac = 5f;
			}


		}
		sayac2 -= Time.deltaTime;
	}

	void Shoot()
    {
		
		Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
		
	}
	void Shoot2()
	{

		Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
		openportal= true;

}

}
