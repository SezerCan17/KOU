using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public float sayac2;
    public Animator myanim;
    public GameObject bulletPrefab2;
    public Transform firePoint;
    public bool openportal = false;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {

            if (sayac2 < 0)
            {

                myanim.SetTrigger("shoot");
                Shoot2();
                sayac2 = 1f;
            }


        }
        sayac2 -= Time.deltaTime;
    }

    void Shoot2()
    {

        Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation);
        openportal = true;

    }
}
    
