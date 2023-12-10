using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
	public float sayac;

	public bool canUse = false;

	public float sayac2;
	public float sayac3;
	public GameObject bulletPrefab2;

	public GameObject bulletPrefab3;

	public Animator myanim;
	// Update is called once per frame

	public bool openportal = false;

	void Update()
	 {
		
		if (Input.GetButtonDown("Fire1"))
		{
			if(sayac < 0)
			{
				myanim.SetTrigger("shoot");
				Shoot();
				sayac = 1f;
			}
			

		}
		sayac -= Time.deltaTime;
		if(Input.GetButtonDown("Fire2"))
		{
			
			if (sayac2 < 0)
			{

				myanim.SetTrigger("shoot");
				Shoot2();
				sayac2 = 1f;
			}


		}
		sayac2 -= Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.T) && canUse)
		{
			
			if (sayac3 < 0)
			{
				myanim.SetTrigger("shoot");
				Shoot3();
				sayac3 = 1f;
			}


		}
		sayac3 -= Time.deltaTime;
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
	void Shoot3()
	{

		Instantiate(bulletPrefab3, firePoint.position, firePoint.rotation);

	}

}
