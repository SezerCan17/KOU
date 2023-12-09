using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class movment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
	private Vector2 theScale;
	private Animator myanims;
	

	private bool m_FacingRight = true;

	float dirX;


	private float vertical;
	private float speed=8f;
	private bool isLadder;
	private bool isClimbing;
	private bool isJumping=false;
	[SerializeField] private SpriteRenderer RS;
	void Start()
	{
		myanims= GetComponent<Animator>();
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
        myanims.SetFloat("run", Mathf.Abs(dirX));

        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
		if (Input.GetButtonDown("Jump") && isJumping == true)
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

		
			if (dirX > 0 && !m_FacingRight || dirX < 0 && m_FacingRight)
			{
				m_FacingRight = !m_FacingRight;
				transform.Rotate(0, 180, 0);
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
	private void OnCollisionEnter2D(Collision2D collision)
	{
	
		if (collision.gameObject.CompareTag("enemies"))
		{
			rb.velocity = new Vector2(15f, 15f);
		}

	}
}
