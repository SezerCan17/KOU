using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Direction : MonoBehaviour
{
    private float hareketHizi;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        HareketKontrol();
    }

    void HareketKontrol()
    {
        float hareketInput = Input.GetAxis("Horizontal");
        Vector2 hareket = new Vector2(hareketInput, 0);
        rb.velocity = new Vector2(hareket.x * hareketHizi, rb.velocity.y);

        // Hareket y�n�ne g�re sprite'� d�nd�r
        if (hareket.x > 0)
        {
            spriteRenderer.flipX = false; // Sa�a bak
        }
        else if (hareket.x < 0)
        {
            spriteRenderer.flipX = true; // Sola bak
        }
        else
        {
            // Hareket etmiyorsa (hareket.x == 0), karakterin mevcut y�n�n� koru
            spriteRenderer.flipX = (rb.velocity.x < 0);
        }
    }
}


