using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_patrolling : MonoBehaviour
{
    public Transform noktaA;
    public Transform noktaB;
    public float hareketHizi = 3f;
    public bool rlook;
    public Rigidbody2D rb;
    AITrigger aITrigger;

    private Transform hedefNokta;

    void Start()
    {
        if (noktaA == null || noktaB == null)
        {
            Debug.LogError("Lütfen A ve B noktalarýný doðru bir þekilde ayarlayýn.");
        }

        // Baþlangýçta hedef A noktasý olsun
        hedefNokta = noktaA;
        rlook = false;
    }

    void Update()
    {
        if(rb.velocity.x<0)
        {
            rlook = false;
        }
        else
        {
            rlook = true;
        }
        
        HedefeGit();
    }

    void HedefeGit()
    {
        if (hedefNokta == null)
            return;
       

        // Hedef noktaya doðru hareket et
        transform.position = Vector2.MoveTowards(transform.position, hedefNokta.position, hareketHizi * Time.deltaTime);

        // Eðer düþman hedef noktaya ulaþtýysa, hedefi deðiþtir
        if (Vector2.Distance(transform.position, hedefNokta.position) < 0.1f)
        {
            if (hedefNokta == noktaA)
            {
                Debug.Log("A da");
                hedefNokta = noktaB;
                rlook = true;
            }
            else
            {
                Debug.Log("B de");
                hedefNokta = noktaA;
                rlook=false;
            }
        }

        // Hedef noktanýn yönüne göre sprite'ýn yönünü ayarla

        if (transform.position.x > hedefNokta.position.x )
        {

            // Hedef sol taraftaysa, karakteri sola bakacak þekilde döndür
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else 
        {
            // Hedef sað taraftaysa, karakteri doðru yöne bakacak þekilde döndür
            transform.localScale = new Vector3(1, 1, 1);
        }
        
    }

}
