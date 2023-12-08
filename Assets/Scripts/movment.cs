using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class movment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;


	float dirX;


	private float vertical;
	private float speed=8f;
	private bool isLadder;
	private bool isClimbing;
	private bool isJumping=false;
	[SerializeField] private SpriteRenderer RS;
	void Start()
	{
		
	}
	void Update()
    {
		if (rb.velocity.y <= 0.01f && rb.velocity.y>= -0.01f)
		{
			isJumping = true;
		}
		Movement();
		Climbing();
		PlayerDirection();

    }
	void Movement()
	{
		dirX = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
		if (Input.GetButtonDown("Jump") && isJumping==true)
		{
			rb.velocity = new Vector2(rb.velocity.x, 10f);
			isJumping = false;
		}
	}
	void Climbing()
	{
		vertical = Input.GetAxis("Vertical");
		if (isLadder && Mathf.Abs(vertical) > 0f)
		{
			isClimbing = true;
		}
	}
	void PlayerDirection()
	{
		if (rb.velocity.x > 0)
		{
			RS.flipX = false;
		}
		else if (rb.velocity.x < 0)
		{
			RS.flipX=true;
		}
		
	}
	private void FixedUpdate()
	{
		if (isClimbing)
		{
			rb.gravityScale = 0f;
			rb.velocity = new Vector2 (rb.velocity.x,vertical*speed);
		}
		else
		{
			rb.gravityScale=5f;
		}
	}
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Ladder"))
		{
			isLadder= true;
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.CompareTag("Ladder"))
		{
			isLadder= false;
			isClimbing= false;
		}
	}
}
