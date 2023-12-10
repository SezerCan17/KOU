using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon3 : MonoBehaviour
{
    public float sayac3;
    public Animator myanim;
    public GameObject bulletPrefab3;
    public Transform firePoint;
    public bool openportal = false;
    public bool canUse = false;

    private void Update()
    {
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
    void Shoot3()
    {

        Instantiate(bulletPrefab3, firePoint.position, firePoint.rotation);

    }
}




