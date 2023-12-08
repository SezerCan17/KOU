using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    movment mov;
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
		  rb.velocity = transform.right * speed;
	}
	void Update()
	{
		Destroy(gameObject,1f);
	}
}
